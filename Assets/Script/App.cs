using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Ionic.Zip;
using LitJson;
using System.Collections.Generic;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;

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
        appdomain.Invoke(method, null, null);
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

