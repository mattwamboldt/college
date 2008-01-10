//Title:             Synchronus chat program
//Purpose:           Acting as either a server or client the program
//                   will connect to another instance of itself and exchange messages
//                   until one side leaves, either foreably or by entering quit
//Author:            Matthew Wamboldt
//Date:              January 5th, 2008
//Last Modified:     January 9th, 2008

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Chat{
	class Chat{
		static void Main( string[] arguments ){
			string usage = "Usage:\n\tChat [-server]";
			int port = 3030;
			TcpClient client = new TcpClient();
            bool is_broken = false;

			//checks that if options are entered they are correct
			if( arguments.Length >= 1 ){
				if( arguments[0] == "-server" && arguments.Length == 1 ){
					//start server and wait for the incoming connection
					Console.WriteLine( "Server started on port {0}", port );
					try{
                        TcpListener server = new TcpListener(IPAddress.Any, port);
					    server.Start();
					    client = server.AcceptTcpClient();
						Console.WriteLine( "Client connected" );
					    server.Stop();
					}
                    catch( Exception e ){
						Console.WriteLine( "Could not start server" );
                        is_broken = true;
					}
				}
                else{
					Console.Write( usage );
                    is_broken = true;
				}
			}
            else{
                //attempt to connect a client to a server
				try{
					client.Connect( Dns.GetHostName(), port );
					Console.WriteLine( "Connected to Server" );	
				}
                catch( Exception e ){
					Console.WriteLine( "Server not found" );
                    is_broken = true;
				}
			}

            if( !is_broken ){
                //begins chat session until someone quits
                NetworkStream stream = client.GetStream();
			    string message = string.Empty;
			    string reply = string.Empty;
			    char key;
    			
			    while( message != "quit" && reply != "quit" ){
				    try{
					    if( Console.KeyAvailable ) {
						    key = Console.ReadKey( true ).KeyChar;
    						
						    if( key == 'I' || key == 'i' ){
                                //send a line to the other user
							    Console.Write( ">> " );

							    message = Console.ReadLine();
                                byte[] write_buffer = Encoding.ASCII.GetBytes( message );
							    stream.Write( write_buffer, 0, write_buffer.Length );
						    }
					    }
                        else{
                            //recieve a line from the other user
						    reply = "";
                            byte[] read_buffer = new byte[1024];

						    while( stream.DataAvailable ){
                                int bytes_recieved = stream.Read( read_buffer, 0, 1024 );
                                reply += Encoding.ASCII.GetString( read_buffer, 0, bytes_recieved);
						    }
    						
						    if( reply != string.Empty && reply != "quit" ){
							    Console.WriteLine( reply );
						    }
					    }
				    }
                    catch( Exception e ){
					    Console.WriteLine( "Connection Lost." );
					    message = "quit";
				    }

    				//keeps application from using up too much cpu power
				    Thread.Sleep( 100 );
			    }
    			
                //gracefully shuts down
			    stream.Close();
			    client.Close();
            }
		}
	}
}
