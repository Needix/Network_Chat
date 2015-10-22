// ServerSocket.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System.Net.Sockets;
using Network_Library.Network.Server;

namespace Network_Chat.ProjectSRC.Controller.Server {
    public class ServerSocket : Network_Library.Network.Server.ServerSocket {
        public ServerSocket(ServerAcceptor acceptor, TcpClient tcpClient) : base(acceptor, tcpClient) {}

        protected override void SearchCommand(string cmd, params object[] param) {
            throw new System.NotImplementedException();
        }
    }
}