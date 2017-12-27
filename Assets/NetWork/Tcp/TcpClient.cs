﻿using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using System.Collections.Generic;
using System.Threading;
using Google.Protobuf;
using System.Net;

/// <summary>
/// tcp 客户端
/// </summary>
public class TcpClient
{
    private Socket socket;
    //==
    private Thread recvThraed;
    //==
    private NetBase parent;
    //==数据
    private int BufferSize = 1024;
    private List<byte[]> RecvBuffer_Add;
    private List<byte> RecvBuffer;
    private byte[] buffer;
    public Action<bool> ConnectResultEvent;
    public Action DisConnectEvent;
    private int RunState = 0;
    public bool has_send = false, has_recv = false;
    public float last_send = 0, Last_recv = 0;
    public int state = 0;

    public TcpClient(NetBase _parent)
    {
        this.buffer = new byte[BufferSize];
        RecvBuffer = new List<byte>();
        RecvBuffer_Add = new List<byte[]>();

        parent = _parent;
    }

    #region 连接
    public void ConnectAsync(string host, int port)
    {
        CloseNetwork();
        try
        {
            Debug.Log("开始连接:" + host + "," + port);

            IPAddress[] address = Dns.GetHostAddresses(host);
            if (address[0].AddressFamily == AddressFamily.InterNetworkV6)
            {
                //Debug.Log("Connect InterNetworkV6");
                socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
            }
            else
            {
                //Debug.Log("Connect InterNetwork");
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            socket.NoDelay = true;
            socket.BeginConnect(host, port, new AsyncCallback(OnConnect), null);
        }
        catch
        {
            if (ConnectResultEvent != null)
            {
                ConnectResultEvent(false);
            }
            return;
        }
    }
    private void OnConnect(IAsyncResult result)
    {
        try
        {
            socket.EndConnect(result);
            state = 10;
            StartRrcv();
            if (ConnectResultEvent != null)
            {
                ConnectResultEvent(true);
            }
        }
        catch (Exception ex)
        {
            state = -1;
            Debug.Log("OnConnect Error:" + ex.ToString());
            if (ConnectResultEvent != null)
            {
                ConnectResultEvent(false);
            }
            return;
        }
    }
    public void Disconnect()
    {
        Debug.Log("==Disconnect==");
        if (DisConnectEvent != null)
        {
            DisConnectEvent();
        }
        CloseNetwork();
    }
    public void ClearConnEvent()
    {
        ConnectResultEvent = null;
    }
    private void CloseNetwork()
    {
        state = -1;
        try
        {
            if (socket != null)
            {
                try
                {
                    socket.Close();
                }
                catch { }
                socket = null;
            }
        }
        catch { }
        try
        {
            if (recvThraed != null)
            {
                recvThraed.Abort();
                recvThraed = null;
            }
        }
        catch
        { }
    }
    #endregion

    #region 接收数据
    public void StartRrcv()
    {
        Debug.Log("开始接受数据");
        lock (RecvBuffer_Add) { }
        recvThraed = new Thread(ProcessReceive);
        recvThraed.Start();
    }
    /// <summary>
    /// 接收数据
    /// </summary>
    /// <param name="e"></param>
    private void ProcessReceive()
    {
        try
        {
            while (state > 0)
            {
                // 检查远程主机是否关闭连接
                int bytesRead = socket.Receive(buffer);
                if (RecvBuffer_Add != null)
                {
                    if (bytesRead <= 0)
                    {
                        Debug.Log("==BytesTransferred等于0退出==" + bytesRead);
                        Disconnect();
                        return;
                    }
                    has_recv = true;
                    //===拷贝数据到缓存===
                    byte[] new_data = new byte[bytesRead];
                    Buffer.BlockCopy(buffer, 0, new_data, 0, bytesRead);
                    //Debug.Log("收到数据:" + bytesRead);
                    lock (RecvBuffer_Add)
                    {
                        RecvBuffer_Add.Add(new_data);
                    }
                }
                else
                {
                    return;
                }
            }
        }
        catch
        {

        }
    }

    Int32 DataSize = 0, id = 0, protocol = 0, body_key = 0, MsgSize = 0, cmd = 0;
    byte[] int_data = new byte[4];
    /// <summary>
    /// 处理数据
    /// </summary>
    private void DealData()
    {
        if (RecvBuffer_Add.Count > 0)
        {
            lock (RecvBuffer_Add)
            {
                for (int i = 0; i < RecvBuffer_Add.Count; i++)
                {
                    for (int j = 0; j < RecvBuffer_Add[i].Length; j++)
                    {
                        RecvBuffer.Add(RecvBuffer_Add[i][j]);
                    }
                }
                RecvBuffer_Add.Clear();
            }
        }
        if (RecvBuffer.Count >= 20)
        {
            for (int i = 0; i < 10; i++)
            {
                if (RecvBuffer.Count >= 20)
                {
                    DataSize = 0; id = 0; protocol = 0; body_key = 0; MsgSize = 0; cmd = 0;
                    BytesToInt(RecvBuffer, 0, ref DataSize);//包长度

                    if (DataSize < 20)
                    {
                        Disconnect();
                        return;
                    }

                    if (DataSize <= RecvBuffer.Count)//包长度小于于接受数据长度
                    {
                        BytesToInt(RecvBuffer, 4, ref id);
                        BytesToInt(RecvBuffer, 8, ref protocol);
                        BytesToInt(RecvBuffer, 12, ref cmd);//命令
                        BytesToInt(RecvBuffer, 16, ref body_key);//

                        MsgSize = DataSize - 20;//消息体长度
                        if (MsgSize > 0)
                        {
                            byte[] msg_datas = new byte[MsgSize];
                            RecvBuffer.CopyTo(20, msg_datas, 0, (int)MsgSize);
                            parent.Handle(id, cmd, msg_datas);
                        }
                        else
                        {
                            UnityEngine.Debug.Log("2222DataSize:" + DataSize + ",id:" + id + ",protocol:" + protocol + ",cmd:" + cmd + ",body_key:" + body_key + ",MsgSize:" + MsgSize);
                            UnityEngine.Debug.LogError("数据错误：" + DataSize + "--" + RecvBuffer.Count);
                        }
                        RecvBuffer.RemoveRange(0, DataSize);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }

    public void BytesToInt(List<byte> data, int offset, ref Int32 num)
    {
        for (int i = 0; i < 4; i++)
        {
            int_data[i] = data[offset + i];
        }
        num = BitConverter.ToInt32(int_data, 0);
    }
    #endregion

    #region 发送      
    public void Send(UInt32 id, UInt32 protocol, Int32 cmd, byte[] msg)
    {
        if (state < 0) { return; }
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
        //UnityEngine.Debug.Log("send44444");
        //socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(send_back), null);
        string str = "";
        for (int i = 0; i < data.Length; i++)
        {
            str += data[i].ToString();
        }
        //UnityEngine.Debug.Log("发送数据:" + str);
        //UnityEngine.Debug.Log("数据长度:" + data.Length);

        try
        {
            has_send = true;
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(send_back), null);
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogError("发送数据错误:" + ex.ToString());
            Disconnect();
        }

    }
    public void Send(byte[] datas)
    {
        if (state < 0) { return; }
        try
        {
            has_send = true;
            socket.BeginSend(datas, 0, datas.Length, SocketFlags.None, new AsyncCallback(send_back), null);
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogError("发送数据错误:" + ex.ToString());
            Disconnect();
        }

    }
    private void send_back(IAsyncResult ar)
    {
        if (state < 0) { return; }
        try
        {
            int bytesSent = socket.EndSend(ar);
        }
        catch
        {

        }
    }
    #endregion

    public void Update()
    {
        //Debug.Log("tcp state:" + state);
        if (state > 0)
        {
            DealData();
            if (has_send) { has_send = false; last_send = Time.time; }
            if (has_recv) { has_recv = false; Last_recv = Time.time; }
            if ((last_send > 0) && ((Time.time - last_send) >= parent.HeartTime))
            {//没间隔1秒发一个心跳包
                parent.SendHeart();
            }
            if ((Last_recv > 0) && ((Time.time - Last_recv) >= parent.DisConnTime))
            {//居然间隔9秒都没有数据，断线了
                Debug.LogError("=======居然间隔6秒都没有数据，断线了:" + (Last_recv - last_send));
                Last_recv = -1;
                Disconnect();
            }
        }
    }


    public void End()
    {
        if (state != -100)
        {
            state = -100;
            //==
            parent = null;
            //==
            RecvBuffer_Add = null;
            RecvBuffer = null;
            buffer = null;
            ConnectResultEvent = null;
            DisConnectEvent = null;

            //==
            if (socket != null)
            {
                try
                {
                    socket.Close();
                }
                catch (Exception)
                {
                }
                socket = null;
            }
            //==
            if (recvThraed != null)
            {
                recvThraed.Abort();
                recvThraed = null;
            }
        }
    }
}

public class BuffItem
{
    public byte[] datas;
    public bool Over;
    public int total_length;
}
