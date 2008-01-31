//Title:			Server Class definition
//Purpose:			Code to Manage the connections and message transfer of clients on the server
//Author:			Matthew Wamboldt
//Date: 			January 26th, 2008
//Last Modified:	January 31st, 2008
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace NetworkingLibrary
{
    public class Server
    {
        private TcpListener server;
        private int last_id = 0;
        //used to keep track of the clients
        private List<ServerConnection> connections = new List<ServerConnection>();
        private Thread connectionListener;

        //message recieve definitions
        public delegate void MessageReceivedHandler(string message, int id);
        public event MessageReceivedHandler MessageReceived;

        //creates a new serever at the loopback address and starts the connection thread
        public Server()
        {
            server = new TcpListener(IPAddress.Any, 3030);
            server.Start();
            connectionListener = new Thread(new ThreadStart(WaitForConnections));
            connectionListener.Start();
        }

        //sends a message to all connected clients
        public void Broadcast(string message)
        {
            foreach (ServerConnection connection in connections)
            {
                connection.SendMessage(message);
            }
        }

        //removes clients that have disconnected
        public void ClientDisconnectHandler(int id)
        {
            for (int i = 0; i < connections.Count; i++)
            {
                if (connections[i].GetId() == id)
                {
                    connections.RemoveAt(i);
                }
            }
        }

        //closes all threads
        public void ShutDown()
        {
            foreach(ServerConnection connection in connections)
            {
                connection.ShutDown();
            }
            connectionListener.Abort();
        }

        //continuously waits for connections up to a maximum of 5
        public void WaitForConnections()
        {
            while (true)
            {
                if (!server.Pending() || connections.Count >= 5)
                {
                    Thread.Sleep(100);
                }
                else
                {
                    //add a new connection
                    lock (connections)
                    {
                        connections.Add(new ServerConnection(last_id, server,
                            new ServerConnection.MessageReceivedHandler(ServerMessageHandler),
                            new ServerConnection.ClientDisconnectedHandler(ClientDisconnectHandler)));
                        last_id++;
                    }
                }
            }
        }

        //passes message through server and out to application
        public void ServerMessageHandler(string message, int id)
        {
            MessageReceived(message, id);
        }

        //locates the connection with the proper id and forwards the message
        public void SendMessage(string message, int clientId)
        {
            for (int i = 0; i < connections.Count; i++)
            {
                if (connections[i].GetId() == clientId)
                {
                    connections[i].SendMessage(message);
                }
            }
        }
    }
}
