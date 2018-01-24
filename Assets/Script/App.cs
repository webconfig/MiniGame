using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Ionic.Zip;
using LitJson;
using System.Collections.Generic;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using System.Collections;

public class App : MonoBehaviour
{
    private static App _instance;
    public static App Instance
    {
        get
        {
            return _instance;
        }
    }

    public GameObject Loading;
    public NetBase network;
    public Text text;
    public Image img;
    public ILRuntime.Runtime.Enviorment.AppDomain appdomain;
    [System.NonSerialized]
    public int _run = 0;
    public RunTyp type;
    public string name = "";
    private string data_path;

    private void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        _instance = this;
        if (!Loading.activeInHierarchy)
        {
            Loading.SetActive(true);
        }
        text.text = "Loading...";
    }

    void Start()
    {
        //CreateImg();
        switch (type)
        {
            case RunTyp.发布正式:

                break;
            case RunTyp.发布覆盖测试:
                GUIConsole gUIConsole = gameObject.AddComponent<GUIConsole>();
                gUIConsole._consoleSize = new Vector2(800, 600);
                GUIConsoleButton gUIConsoleButton = gameObject.AddComponent<GUIConsoleButton>();
                gUIConsoleButton._buttonRect = new Rect(100f, 300f, 100f, 100f);
                RunTest();
                break;
            case RunTyp.本地覆盖测试:
                RunTest();
                break;
            case RunTyp.不覆盖运行:
                LoadTest();
                break;
        }
        //InitBtn();
    }

    private void Update()
    {
        //Debug.Log(Time.deltaTime);
        if (_run == -1)
        {//游戏结束
            _run = 0;
            AssetbundleLoader.Clear();//释放资源
            EndNetWork();
            //Buffer.BlockCopy(buf, 20, msg_datas, 0, MsgSize);
            appdomain = null;
        }
        else if (_run > 0)
        {
            if (network != null)
            {
                network.Update();
            }
            appdomain.Invoke(method_update, null, null);
        }
    }


    public void InitNetWork(string ip,int port, float _HeartTime, float _DisConnTime, NetWorkType type)
    {
        EndNetWork();
        network = new NetBase(ip,port, _HeartTime, _DisConnTime, type);
    }
    public void EndNetWork()
    {
        if(network!=null)
        {
            network.End();
            network = null;
        }
    }

    /// <summary>
    /// 加载游戏
    /// </summary>
    /// <param name="game"></param>
    public void Load(string game)
    {
        if (_run == -1)
        {//游戏结束
            AssetbundleLoader.Clear();//释放资源
            appdomain = null;
        }
        _run = 0;

#if UNITY_EDITOR || UNITY_ANDROID
        data_path = Application.persistentDataPath;
#elif UNITY_IOS
        data_path = Application.temporaryCachePath;
#endif


        Debug.Log("开始加载游戏：" + data_path);
        //===ab初始化====
        AssetbundleLoader.Init(data_path,game);
        //===加载热更新代码===
        LoadHotFixAssembly(game);
        Debug.Log("启动完成");
    }
    /// <summary>
    /// 玩家1头像改变
    /// </summary>
    /// <param name="data"></param>
    public void player1PicChange(string data)
    {
        if (appdomain != null)
        {
            appdomain.Invoke("HotFix_Project.Main", "player1PicChange", null, data);
        }
    }
    /// <summary>
    /// 玩家2头像改变
    /// </summary>
    /// <param name="data"></param>
    public void player2PicChange(string data)
    {
        if (appdomain != null)
        {
            appdomain.Invoke("HotFix_Project.Main", "player2PicChange", null, data);
        }
    }

    #region 加载代码
    /// <summary>
    /// 加载代码
    /// </summary>
    /// <param name="game"></param>
    void LoadHotFixAssembly(string game)
    {
        appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
        string dll_path = string.Format("{0}/game/{1}/{2}", data_path, game, "HotFix_Project.dll");
        byte[] dll = File.ReadAllBytes(dll_path);
        string dll_pdb_path = string.Format("{0}/game/{1}/{2}", data_path, game, "HotFix_Project.pdb");
        byte[] pdb = File.ReadAllBytes(dll_pdb_path);
        using (System.IO.MemoryStream fs = new MemoryStream(dll))
        {
            using (System.IO.MemoryStream p = new MemoryStream(pdb))
            {
                appdomain.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
            }
        }
        //此处调用初始化
        InitializeILRuntime();
        //ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);
        Assets.CommGen.Initialize(appdomain);
        OnHotFixLoaded();
    }

    void InitializeILRuntime()
    {
        //这里做一些ILRuntime的注册，HelloWorld示例暂时没有需要注册的
        appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
        {
            return new UnityEngine.Events.UnityAction(() =>
            {
                ((Action)act)();
            });
        });
        appdomain.DelegateManager.RegisterMethodDelegate<NetBase, System.Byte[], System.Int32>();
        appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean>();

        appdomain.DelegateManager.RegisterMethodDelegate<System.IAsyncResult>();
        appdomain.DelegateManager.RegisterDelegateConvertor<System.AsyncCallback>((act) =>
        {
            return new System.AsyncCallback((ar) =>
            {
                ((Action<System.IAsyncResult>)act)(ar);
            });
        });
        appdomain.DelegateManager.RegisterMethodDelegate<System.Int32, System.Byte[]>();
        appdomain.DelegateManager.RegisterDelegateConvertor<System.Threading.ThreadStart>((act) =>
        {
            return new System.Threading.ThreadStart(() =>
            {
                ((Action)act)();
            });
        });
        //====proto=======
        appdomain.RegisterCrossBindingAdaptor(new Adapt_IMessage());
        appdomain.DelegateManager.RegisterFunctionDelegate<Adapt_IMessage.Adaptor>();
        appdomain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        LitJson.JsonMapper.RegisterILRuntimeCLRRedirection(appdomain);

        //预先获得IMethod，可以减低每次调用查找方法耗用的时间
        IType type = appdomain.LoadedTypes["HotFix_Project.Main"];
        //根据方法名称和参数个数获取方法
        method = type.GetMethod("Run", 0);
        method_update = type.GetMethod("Update", 0);
    }
    private IMethod method,method_update;
    /// <summary>
    /// 启动代码
    /// </summary>
    void OnHotFixLoaded()
    {
        appdomain.Invoke(method, null, null);
        _run = 1;
        Loading.gameObject.SetActive(false);
    }
    #endregion

    #region 热更新工程接口
    private ios_sdk _ios_sdk = new ios_sdk();
    /// <summary>
    /// 结束
    /// </summary>
    public void Over()
    {
        _run = -1;
        Loading.gameObject.SetActive(true);
        text.text = "";
        //Debug.Log("=====game over=======");
    }
    public void getPlayer1()
    {
        //Debug.Log("主工程getPlayer1接口");
        if (_ios_sdk!=null)
        {
            _ios_sdk.GetPlayer1();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getPlayer2()
    {
        //Debug.Log("主工程getPlayer2");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetPlayer2();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getPlayer1Pic()
    {
        //Debug.Log("主工程getPlayer1Pic");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetPlayer1Img();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getPlayer2Pic()
    {
        //Debug.Log("主工程getPlayer2Pic");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetPlayer2Img();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getRoomId()
    {
        //Debug.Log("主工程getRoomId");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetRoomId();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getToken()
    {
        //Debug.Log("主工程getToken");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetToken();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void getServer()
    {
        //Debug.Log("主工程getServer");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetServer();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }

    public void getGameId()
    {
        //Debug.Log("主工程getServer");
        if (_ios_sdk != null)
        {
            _ios_sdk.GetGameId();
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }

    public void end(string result)
    {
        //Debug.Log("主工程end");
        if (_ios_sdk != null)
        {
            _ios_sdk.End(result);
        }
        else
        {
            Debug.Log("_ios_sdk 空");
        }
    }
    public void commonFunction(string result)
    {
        //Debug.Log("主工程end");
        if (_ios_sdk != null)
        {
            _ios_sdk.CommonFunction(result);
        }
        else
        {
            Debug.Log("CommonFunction 空");
        }
    }
    public void BackData(string data)
    {
        if (appdomain != null)
        {
            appdomain.Invoke("HotFix_Project.Main", "BackData", null, data);
        }
    }
    public long ToUnixTime()
    {
        //UnityEngine.Debug.Log(DateTime.UtcNow.ToString());
        double k = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        return Convert.ToInt64(k);
    }
    public void DoCoroutine(IEnumerator coroutine)
    {
        StartCoroutine(coroutine);
    }
    #endregion



    //======测试======
    public void LoadTest()
    {
       Load(name);
    }
    public void RunTest()
    {
        Run(name);
    }
    /// <summary>
    /// 运行游戏(测试用)
    /// </summary>
    /// <param name="game">游戏名称</param>
    public void Run(string game)
    {
#if UNITY_EDITOR || UNITY_ANDROID
        data_path = Application.persistentDataPath;
#elif UNITY_IOS
        data_path = Application.temporaryCachePath;
#endif
        Debug.Log("路径：" + data_path);
#if UNITY_EDITOR
        string ZipPath = string.Format("{0}/game/{1}", data_path, game);
        using (var zf = ZipFile.Read(@"Assets/StreamingAssets/" + game + ".zip"))
            zf.ExtractAll(ZipPath, ExtractExistingFileAction.OverwriteSilently);
#elif UNITY_STANDALONE_WIN
                                        string game_path = string.Format("{0}/{1}", data_path, zip_game);
                                        if (!System.IO.Directory.Exists(game_path))
                                        {
                                            System.IO.Directory.CreateDirectory(game_path);
                                        }

                                        var loadDb2 = new WWW("file://" + Application.dataPath + "/StreamingAssets/bin.zip");
                                        while (!loadDb2.isDone) { }
                                        string ZipFilePath = string.Format("{0}/bin.zip", game_path, zip_game);
                                        File.WriteAllBytes(ZipFilePath, loadDb2.bytes);
                                        Debug.Log("zip_file_path:" + ZipFilePath);

                                        //ZipUtil.Unzip(ZipFilePath, game_path);
                                        using (var zf = ZipFile.Read(ZipFilePath))
                                         zf.ExtractAll(game_path, ExtractExistingFileAction.OverwriteSilently);
                                            File.Delete(ZipFilePath);
                                        Debug.Log("Ok");
#elif UNITY_ANDROID
        string game_path = string.Format("{0}/game/{1}", data_path, game);
        if (!System.IO.Directory.Exists(game_path))
        {
            System.IO.Directory.CreateDirectory(game_path);
        }

        var loadDb2 = new WWW("jar:file://" + Application.dataPath + "!/assets/" + game + ".zip");
        while (!loadDb2.isDone) { }
        string ZipFilePath = string.Format("{0}/" + game + ".zip", game_path);
        File.WriteAllBytes(ZipFilePath, loadDb2.bytes);
        Debug.Log("zip_file_path:" + ZipFilePath);

        using (var zf = ZipFile.Read(ZipFilePath))
            zf.ExtractAll(game_path, ExtractExistingFileAction.OverwriteSilently);
        File.Delete(ZipFilePath);
        Debug.Log("Ok");
#elif UNITY_IOS
                        string game_path = string.Format("{0}/game/{1}", data_path, game);
                        if (!System.IO.Directory.Exists(game_path))
                        {
                            System.IO.Directory.CreateDirectory(game_path);
                        }
                        string ZipFilePath = "";

                        byte[] datas = System.IO.File.ReadAllBytes(Application.streamingAssetsPath + @"/" + game + ".zip");
                        ZipFilePath = string.Format("{0}/" + game + ".zip", game_path);

                        File.WriteAllBytes(ZipFilePath, datas);

                        using (var zf = ZipFile.Read(ZipFilePath))
                            zf.ExtractAll(game_path, ExtractExistingFileAction.OverwriteSilently);

                        DirectoryInfo TheFolder = new DirectoryInfo(game_path);
                        //遍历文件
                        foreach (FileInfo NextFile in TheFolder.GetFiles())
                        {
                            Debug.Log("file:" + NextFile.FullName);
                        }

                        File.Delete(ZipFilePath);
                        Debug.Log("Ok");
#endif
        Load(game);
    }

    //public void CreateImg()
    //{
    //    string str = "83|83|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";
    //    img.sprite = GetPlayerImg(str);
    //}

    //public static Sprite GetPlayerImg(string str)
    //{
    //    if (!string.IsNullOrEmpty(str))
    //    {
    //        string[] datas = str.Split('|');
    //        int width = int.Parse(datas[0]);
    //        int height = int.Parse(datas[1]);
    //        string byteStr = datas[2];
    //        Debug.Log("用户1图片：" + width + "," + height + "," + byteStr);
    //        //==============
    //        Sprite sprite = null;
    //        try
    //        {
    //            byte[] img_datas = Convert.FromBase64String(byteStr);
    //            Texture2D tex = new Texture2D(width, height);

    //            tex.LoadImage(img_datas);

    //            sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
    //        }
    //        catch (Exception ex)
    //        {
    //            Debug.Log("获取用户1图片错误：" + ex.ToString());
    //        }
    //        return sprite;
    //    }
    //    else
    //    {
    //        Debug.Log("获取Player1 错误");
    //        return null;
    //    }
    //}

    //public List<string> list = new List<string>();
    //public Text msg_test;
    //public System.Text.StringBuilder str_builder = new System.Text.StringBuilder();
    //public void AddMsg(string str)
    //{
    //    list.Add(DateTime.Now.ToString("HH:mm:ss:fff-->") + str+ "\n");
    //    if(list.Count>20)
    //    {
    //        list.RemoveAt(0);
    //    }
    //    str_builder = new System.Text.StringBuilder();
    //    for (int i = 0; i < list.Count; i++)
    //    {
    //        str_builder.Append(list[i]);
    //    }
    //    msg_test.text = str_builder.ToString();
    //}

    //public Button button;
    //public string list_strs ="";
    //public void InitBtn()
    //{
    //    button.onClick.AddListener(Write);
    //}
    //public void AddNetWork(int str)
    //{
    //    list_strs += DateTime.Now.ToString("HH:mm:ss:fff-->") + str.ToString() + "\n";
    //}
    //public void Write()
    //{
    //    string log_path = Application.persistentDataPath + "/1.txt";
    //    Debug.Log("日志：" + log_path);
    //    File.AppendAllText(log_path, list_strs);
    //    button.gameObject.SetActive(false);
    //}
}
public enum RunTyp
{
    发布正式= 0,
    发布覆盖测试 = 1,
    本地覆盖测试 = 2,

    不覆盖运行=3

}

