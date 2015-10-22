// ClientSocket.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System.Net.Sockets;

namespace Network_Chat.ProjectSRC.Controller.Client {
    public class ClientSocket : Network_Library.Network.Client.ClientSocket {
        public ClientSocket(TcpClient client) : base(client) {}
        public ClientSocket(string host, int port) : base(host, port) {}

        protected override void SearchCommand(string cmd, params object[] param) {
            throw new System.NotImplementedException();
        }
    }
}