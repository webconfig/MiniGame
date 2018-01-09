using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 网络模块
/// </summary>
public class NetBase
{
    public TcpClient tcp;
    public KCPClient kcp = null;
    public UdpClient udp = null;

    public string ip;
    public int port;
    public int udp_port;

    public float DisConnTime = 3, HeartTime = 1;

    public NetWorkType type;
    /// <summary>
    /// 状态 -1：网络断开  1：连接
    /// </summary>
    public int state;

    public Action DisConnectEvent;
    public Action HeartEvent;
    public Action<bool> ConnectResultEvent;

    public NetBase(string _ip, int _port, float _HeartTime, float _DisConnTime, NetWorkType _type)
    {
        ip = _ip;
        port = _port;
        type = _type;
        DisConnTime = _DisConnTime;
        HeartTime = _HeartTime;
        lock (msg_obj) { }
        switch (type)
        {
            case NetWorkType.Kcp:
                kcp = new KCPClient(this);
                kcp.DisConnectEvent += DisConn;
                kcp.ConnectResultEvent += ConnectBack;
                break;
            case NetWorkType.Tcp:
                tcp = new TcpClient(this);
                tcp.DisConnectEvent += DisConn;
                tcp.ConnectResultEvent += ConnectBack;
                break;
        }
    }

    #region 连接
    public void Conn(uint conv)
    {
        Clear();
        switch (type)
        {
            case NetWorkType.Kcp:
                kcp.Connect(ip, port, conv);
                break;
            case NetWorkType.Tcp:
                tcp.ConnectAsync(ip, port);
                break;
        }
    }
    public void ClearConnEvent()
    {
        DisConnectEvent = null;
        HeartEvent = null;
        ConnectResultEvent = null;
    }
    private void ConnectBack(bool t)
    {
        if (ConnectResultEvent != null)
        {
            ConnectResultEvent(t);
        }
    }
    public void DisConn()
    {
        Debug.LogError("==dis conn==");
        if (DisConnectEvent != null)
        {
            DisConnectEvent();
        }
    }
    #endregion

    #region udp
    public void RunUdp(int _udp_port)
    {
        udp_port = _udp_port;
        udp = new UdpClient(this);
    }
    public void ConnUdp()
    {
        udp.Connect(ip, udp_port);
    }
    public void StartRecvUdp()
    {
        udp.StartRrcv();
    }
    public void UdpSend(UInt32 id, UInt32 protocol, Int32 cmd, byte[] datas)
    {
        udp.Send(id, protocol, cmd, datas);
    }
    public int UdpSend(byte[] datas)
    {
        return udp.Send(datas);
    }
    #endregion

    public object has_send_obj = new object();
    public bool has_send = false, has_recv = false;
    private float last_send = 0, Last_recv = 0;
    private object msg_obj = new object();
    public List<MsgData> msgs = new List<MsgData>();
    public List<MsgData> msgs_all = new List<MsgData>();

    private void Clear()
    {
        lock (msg_obj)
        {
            msgs.Clear();
            has_recv = false;
        }
        msgs_all.Clear();
        lock (has_send_obj)
        {
            has_send = false;
        }
        last_send = 0;
        Last_recv = 0;
    }

    public void HasSend()
    {
        lock (has_send_obj)
        {
            has_send = true;
        }
    }
    public void HasRecv(MsgData obj)
    {
        lock (msg_obj)
        {
            msgs.Add(obj);
        }
    }
    /// <summary>
    /// 处理数据
    /// </summary>
    private void DealData()
    {
        lock (msg_obj)
        {
            if (msgs.Count > 0)
            {
                msgs_all.AddRange(msgs);
                msgs.Clear();
            }
            has_recv = true;
        }
        if (msgs_all.Count > 0)
        {
            for (int i = 0; i < msgs_all.Count; i++)
            {
                Handle(msgs_all[i].id, msgs_all[i].cmd, msgs_all[i].datas);
            }
            BackMsg(msgs_all);
            msgs_all.Clear();
        }
    }
    public void Update()
    {
        if (state > 0)
        {
            DealData();
            if (has_send) { has_send = false; last_send = Time.time; }
            if (has_recv) { has_recv = false; Last_recv = Time.time; }
            if ((last_send > 0) && ((Time.time - last_send) >= HeartTime))
            {//没间隔1秒发一个心跳包
                SendHeart();
            }
            if ((Last_recv > 0) && ((Time.time - Last_recv) >= DisConnTime))
            {//居然间隔9秒都没有数据，断线了
                Debug.LogError("=======居然间隔6秒都没有数据，断线了:" + (Last_recv - last_send));
                Last_recv = -1;
                DisConn();
            }
        }
    }

    #region pool
    public List<MsgData> msg_pool = new List<MsgData>();
    private object msg_pool_obj = new object();
    public MsgData GetMsg()
    {
        lock (msg_pool_obj)
        {
            MsgData msg = null;
            if (msg_pool.Count > 0)
            {
                msg = msg_pool[0];
                msg_pool.RemoveAt(0);
            }
            else
            {
                msg = new MsgData();
            }
            return msg;
        }
    }
    public void BackMsg(List<MsgData> items)
    {
        lock (msg_pool_obj)
        {
            msg_pool.AddRange(items);
        }
    }
    public void ClearMsg()
    {
        lock (msg_pool_obj)
        {
            if (msg_pool != null)
            {
                msg_pool.Clear();
                msg_pool = null;
            }
        }
    }
    #endregion

    public void SendHeart()
    {
        if (HeartEvent != null)
        {
            HeartEvent();
        }
    }
    /// <summary>
    /// 发送数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">玩家id</param>
    /// <param name="protocol">0</param>
    /// <param name="cmd">命令</param>
    /// <param name="t">协议</param>
    public void Send(UInt32 id, UInt32 protocol, Int32 cmd, byte[] datas)
    {
        switch (type)
        {
            case NetWorkType.Kcp:
                kcp.Send(id, protocol, cmd, datas);
                break;
            case NetWorkType.Tcp:
                tcp.Send(id, protocol, cmd, datas);
                break;
        }
    }

    public void Send(byte[] datas)
    {
        switch (type)
        {
            case NetWorkType.Kcp:
                kcp.Send(datas);
                break;
            case NetWorkType.Tcp:
                tcp.Send(datas);
                break;
        }
    }

    public byte[] GetData(UInt32 id, UInt32 protocol, Int32 cmd, byte[] msg)
    {
        uint body_key = Convert.ToUInt32(CRC32Cls.GetCRC32(msg));

        byte[] id_bytes = BitConverter.GetBytes(id);//id
        byte[] protocol_bytes = BitConverter.GetBytes(protocol);//protocol
        byte[] cmd_bytes = BitConverter.GetBytes(cmd);//cmd
        byte[] body_key_bytes = BitConverter.GetBytes(body_key);//cmd

        UInt32 total_length = (UInt32)(id_bytes.Length + protocol_bytes.Length + cmd_bytes.Length + body_key_bytes.Length + msg.Length + 4);

        //消息体结构：消息体长度+消息体
        byte[] data = new byte[total_length];
        BitConverter.GetBytes(total_length).CopyTo(data, 0);
        id_bytes.CopyTo(data, 4);
        protocol_bytes.CopyTo(data, 8);
        cmd_bytes.CopyTo(data, 12);
        body_key_bytes.CopyTo(data, 16);
        msg.CopyTo(data, 20);

        return data;

    }

    #region 处理数据
    public void StartRecv()
    {
        switch (type)
        {
            case NetWorkType.Kcp:
                kcp.StartRrcv();
                break;
            case NetWorkType.Tcp:
                tcp.StartRrcv();
                break;
        }
    }
    //public delegate void PacketHandlerFunc(NetBase client, byte[] datas, Int32 player_id);
    private Dictionary<Int32, Action<NetBase, System.Byte[], System.Int32>> handlers = new Dictionary<int, Action<NetBase, System.Byte[], System.Int32>>();
    public void AddHandle(Int32 cmd, Action<NetBase, System.Byte[], System.Int32> func)
    {
        if (handlers.ContainsKey(cmd))
        {
            handlers[cmd] = func;
        }
        else
        {
            handlers.Add(cmd, func);
        }
    }
    public void RemoveHandle(Int32 cmd)
    {
        if (handlers.ContainsKey(cmd))
        {
            handlers.Remove(cmd);
        }
    }
    public virtual void Handle(Int32 player_id, Int32 command, byte[] datas)
    {
        Action<NetBase, System.Byte[], System.Int32> handler;
        if (!handlers.TryGetValue(command, out handler))
        {
            Debug.Log("未至命令：" + command);
            return;
        }

        try
        {
            //Debug.Log("处理命令：" + command);
            handler(this, datas, player_id);
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.Log(
                "PacketElementTypeException: " + ex.Message + Environment.NewLine +
                ex.StackTrace + Environment.NewLine +
                "Packet: " + Environment.NewLine +
                command.ToString()
            );
        }
    }
    #endregion

    public void End()
    {
        Debug.Log("====end=====");
        switch (type)
        {
            case NetWorkType.Kcp:
                if (kcp != null)
                {
                    kcp.End();
                    kcp = null;
                }
                break;
            case NetWorkType.Tcp:
                if (tcp != null)
                {
                    tcp.End();
                    tcp = null;
                }
                break;
        }
    }
}
public enum NetWorkType
{
    Tcp,
    Kcp
}

