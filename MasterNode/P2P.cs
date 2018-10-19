﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MasterNode
{
    class P2P //V0.1
    {
        delegate void AddMessage(string message);
        Random rnd = new Random();

        int port;
        string broadcastAddress;
        public int lastNumber;
        public int lastNumber2;
        UdpClient receivingClient;
        UdpClient sendingClient;
        static Thread receivingThread;

        public P2P(string ip = "255.255.255.255", int p = 54545)
        {
            port = p;
            broadcastAddress = ip;
            InitializeSender();
            InitializeReceiver();
        }

        public void InitializeSender()
        {
            sendingClient = new UdpClient(broadcastAddress, port);
            sendingClient.EnableBroadcast = true;
        }

        public void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }


        public void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.UTF8.GetString(data);
                messageDelegate(message);
            }
        }

        public void MessageReceived(string message)
        {
            try
            {
                string x = message.Substring(message.Length - 4);
                if (x == Convert.ToString(lastNumber) || x == Convert.ToString(lastNumber2)) { return; }
                message = message.Substring(0, message.Length - 4);
#if DEBUG
                //Debug.WriteLine("In: " + message);
#endif
                Program.ResponseMessage(message);
            }
            catch { Debug.WriteLine("Error: " + message); }


        }

        public void Send(string toSend)
        {
            //Debug.WriteLine("Out: " + toSend);
            lastNumber2 = lastNumber;
            lastNumber = rnd.Next(1000, 9999);
            toSend = toSend + Convert.ToString(lastNumber);
            byte[] data = Encoding.UTF8.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }

    }
}
