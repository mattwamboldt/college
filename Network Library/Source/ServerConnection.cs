//Title:			Server Connection Class definition
//Purpose:			Code to Manage the sending and recieving and connecting of a client on the server
//Author:			Matthew Wamboldt
//Date: 			January 26th, 2008
//Last Modified:	January 31st, 2008
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace NetworkingLibrary
{
    public class ServerConnection
    {
        private TcpClient myClient = new TcpClient();
        private NetworkStream myStream;
        private int myId;

        //receiving definitions
        public delegate void MessageReceivedHandler(string message, int id);
        public event MessageReceivedHandler MessageReceived;

        //client connection definitions
        public delegate void ClientDisconnectedHandler(int id);
        public event ClientDisconnectedHandler ClientDisconnected;
        private Thread messageListener;
        
        public int GetId()
        {
            return myId;
        }

        //starts the recieve and connection threads
        public ServerConnection(int id, TcpListener server, MessageReceivedHandler receiveHandler, ClientDisconnectedHandler disconnectHandler)
        {
            myId = id;
            myClient = server.AcceptTcpClient();
            myStream = myClient.GetStream();
            MessageReceived += new MessageReceivedHandler(receiveHandler);
            ClientDisconnected += new ClientDisconnectedHandler(disconnectHandler);

            messageListener = new Thread(new ThreadStart(ReceiveMessages));
            messageListener.Start();
        }

        //accepts messages from the connected client and sends the information
        //to the server
        private void ReceiveMessages()
        {
            string message = "";
            int bytesReceived = 0;
            byte[] buffer = new byte[1024];
            while (true)
            {
                while (myClient.Client.Poll(10, SelectMode.SelectRead))
                {
                    bytesReceived = myStream.Read(buffer, 0, 1024);
                    if (bytesReceived == 0)
                    {
                        ClientDisconnected(myId);
                        return;
                    }
                    message += Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                }

                if (message.Length > 0)
                {
                    if (message[0] != '~')
                    {
                        //disconnect the client as it is an unwanted connection
                        SendMessage("Invalid connection.");
                        ShutDown();
                        ClientDisconnected(myId);
                    }
                    else if (message == "~")
                    {
                        //ignore empty messages
                        Thread.Sleep(100);
                    }
                    else
                    {
                        //send the message forward as it is fine
                        MessageReceived(message.TrimStart('~'), myId);
                        message = "";
                    }
                }
            }
        }

        //sends a message to the server
        public void SendMessage(string message)
        {
            if (myClient.Connected)
            {
                myStream.Write(Encoding.ASCII.GetBytes(message), 0, Encoding.ASCII.GetBytes(message).Length);
            }
            else
            {
                ShutDown();
                ClientDisconnected(myId);
            }
        }

        //closes down the client listeneing thread
        public void ShutDown()
        {
            messageListener.Abort();
            myStream.Close();
            myClient.Close();
        }
    }
}
