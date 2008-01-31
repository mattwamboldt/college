//Title:			Client Class definition
//Purpose:			Code to Manage the sending and recieving and connecting of a client
//Author:			Matthew Wamboldt
//Date: 			January 26th, 2008
//Last Modified:	January 31st, 2008
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace NetworkingLibrary
{
    public class Client
    {
        private IPAddress myAddress;
        private int myPort;
        private TcpClient myClient = new TcpClient();
        private NetworkStream myStream;
        private String failureReason;

        //message recieve definitions
        public delegate void MessageReceivedHandler(string message);
        public event MessageReceivedHandler MessageReceived;

        //client connect definitions
        public delegate void ConnectionAttemptCompleteHandler();
        public event ConnectionAttemptCompleteHandler ConnectionAttemptComplete;

        //server disconnect definitions
        public delegate void ServerDisconnectedHandler();
        public event ServerDisconnectedHandler ServerDisconnected;

        private Thread messageListener;

        //creates a new client with the given ip and port
        public Client(IPAddress address, int port)
        {
            myAddress = address;
            myPort = port;
        }

        //Properties
        public IPAddress Address
        {
            get
            {
                return myAddress;
            }
            set
            {
                myAddress = value;
            }
        }

        public int Port
        {
            get
            {
                return myPort;
            }
            set
            {
                myPort = value;
            }
        }

        public bool Connected
        {
            get
            {
                return myClient.Connected;
            }
        }

        public String Failure
        {
            get { return failureReason; }
        }

        //accepts messages from the connected client and sends the information
        private void ReceiveMessages()
        {
            TcpClient client = myClient;
            NetworkStream stream = client.GetStream();
            string message = "";
            int bytesReceived = 0;
            byte[] buffer = new byte[1024];
            while (true)
            {
                while (client.Client.Poll(10, SelectMode.SelectRead))
                {
                    bytesReceived = stream.Read(buffer, 0, 1024);
                    if (bytesReceived == 0)
                    {
                        ServerDisconnected();
                        return;
                    }
                    message += Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                }
                if (message == "")
                {
                    Thread.Sleep(100);
                }
                else
                {
                    MessageReceived(message);
                    message = "";
                    Thread.Sleep(500);
                }  
            }
        }

        //attempts to send a message to the server
        public void SendMessage(string message)
        {
            //we need a common code attached to the front of all messages
            message = "~" + message;
            try
            {
                myStream.Write(Encoding.ASCII.GetBytes(message), 0, Encoding.ASCII.GetBytes(message).Length);
            }
            catch (Exception)
            {
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                TcpClient client = (TcpClient)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                //set up the reading thread
                myStream = myClient.GetStream();
                messageListener = new Thread(new ThreadStart(ReceiveMessages));
                messageListener.Start();
            }
            catch (Exception e)
            {
                failureReason = e.Message;
            }

            //signal to user that connection attempt has completed
            ConnectionAttemptComplete();
        }
        
        //attempts to connect to the server and listen for messages
        public bool Connect()
        {
            try
            {
                myClient.BeginConnect(myAddress, myPort, new AsyncCallback(ConnectCallback), myClient);
                return true;
            }
            catch (Exception e)
            {
                failureReason = e.Message;
                return false;
            }
        }

        //safely shuts down the thread, stream, and client objects
        public void Disconnect()
        {
            if (messageListener != null && messageListener.ThreadState != System.Threading.ThreadState.Stopped)
            {
                messageListener.Abort();
            }
            if (myStream != null)
            {
                myStream.Close();
            }
            if (myClient != null)
            {
                myClient.Close();
            }
        }
    }
}
