// ServerSocket.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Network_Library.Network.Server;
using Message = Network_Library.Network.Messaging.Message;

namespace Network_Chat.ProjectSRC.Controller.Server {
    public class ServerSocket : Network_Library.Network.Server.ServerSocket {
        private readonly GUIController _controller;

        public ServerSocket(GUIController controller, ServerAcceptor acceptor, TcpClient tcpClient) : base(acceptor, tcpClient) {
            _controller = controller;
        }

        public override void OnUserConnect(TcpClient client) {
            base.OnUserConnect(client);
            IPEndPoint ip = (IPEndPoint)client.Client.RemoteEndPoint;
            Debug.WriteLine("Server: Incoming connection: " + ip.Address + ":" + ip.Port);
        }

        protected override void SearchCommand(string cmd, params object[] param) {
            Debug.WriteLine("Server: Recieving CMD: " + cmd);
            switch(cmd) {
                case "KICK":

                    break;
                default:
                    string message = RebuildString(LengthenArray(param, cmd));
                    Debug.WriteLine("Recieved message: " + message);
                    _controller.IncomingMessage(this, message);
                    Send(new Message("MSG", message));
                    break;
            }
        }
    }
}