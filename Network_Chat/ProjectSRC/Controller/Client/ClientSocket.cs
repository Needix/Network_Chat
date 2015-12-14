// ClientSocket.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Network_Chat.ProjectSRC.Controller.Client {
    public class ClientSocket : Network_Library.Network.Client.ClientSocket {
        private readonly GUIController _controller;

        public ClientSocket(GUIController controller, string host, int port) : base(new TcpClient(host, port)) {
            _controller = controller;
        }

        public override void OnUserConnect(TcpClient client) {
            base.OnUserConnect(client);
            IPEndPoint ip = (IPEndPoint)client.Client.RemoteEndPoint;
            Debug.WriteLine("Client: Incoming connection: " + ip.Address + ":" + ip.Port);
        }

        protected override void SearchCommand(string cmd, params object[] param) {
            Debug.WriteLine("Server: Recieving CMD: " + cmd);
            switch(cmd) {
                case "MSG":
                    string message = RebuildString(param);
                    Debug.WriteLine("Recieved message: " + message);
                    _controller.IncomingMessage(this, message);
                    break;
                default:

                    break;
            }
        }
    }
}