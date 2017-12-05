using System;
using System.IO;
using UnityEngine;
using Ionic.Zip;

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
    public ILRuntime.Runtime.Enviorment.AppDomain appdomain;
    [System.NonSerialized]
    public int _run = 0;
    public RunTyp type;
    public string name = "";
    private string data_path;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
        _instance = this;
    }

    void Start()
    {
        switch(type)
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
    }

    //private UnityEngine.UI.Image img;
    //private void TestImage()
    //{
    //    string str = "333 | 333 |/ 9j / 4AAQSkZJRgABAQAASABIAAD / 4QBYRXhpZgAATU0AKgAAAAgAAgESAAMAAAABAAEAAIdpAAQAAAABAAAAJgAAAAAAA6ABAAMAAAABAAEAAKACAAQAAAABAAAAZKADAAQAAAABAAAAZAAAAAD / 7QA4UGhvdG9zaG9wIDMuMAA4QklNBAQAAAAAAAA4QklNBCUAAAAAABDUHYzZjwCyBOmACZjs + EJ +/ 8AAEQgAZABkAwEiAAIRAQMRAf / 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";
    //    //str = str.Replace(" ", "");
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
    //        img.sprite = sprite;
    //    }
    //    else
    //    {
    //        Debug.Log("获取Player1 错误");

    //    }
    //}

    private void Update()
    {
        if (_run == -1)
        {//游戏结束
            _run = 0;
            AssetbundleLoader.Clear();//释放资源
            //Buffer.BlockCopy(buf, 20, msg_datas, 0, MsgSize);
            appdomain = null;
        }
        else if (_run > 0)
        {
            App.Instance.appdomain.Invoke("HotFix_Project.Main", "Update", null, null);
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
        ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);
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

    }

    /// <summary>
    /// 启动代码
    /// </summary>
    void OnHotFixLoaded()
    {
        appdomain.Invoke("HotFix_Project.Main", "Run", null, null);
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
        using (var zf = ZipFile.Read(@"Assets/StreamingAssets/"+ game + ".zip"))
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

        var loadDb2 = new WWW("jar:file://" + Application.dataPath + "!/assets/bin.zip");
        while (!loadDb2.isDone) { }
        string ZipFilePath = string.Format("{0}/bin.zip", game_path);
        File.WriteAllBytes(ZipFilePath, loadDb2.bytes);
        Debug.Log("zip_file_path:" + ZipFilePath);

        //ZipUtil.Unzip(ZipFilePath, game_path);
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

                byte[] datas = System.IO.File.ReadAllBytes(Application.streamingAssetsPath + @"/bin.zip");
                ZipFilePath = string.Format("{0}/bin.zip", game_path);

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
}
public enum RunTyp
{
    发布正式= 0,
    发布覆盖测试 = 1,
    本地覆盖测试 = 2,

    不覆盖运行=3

}

