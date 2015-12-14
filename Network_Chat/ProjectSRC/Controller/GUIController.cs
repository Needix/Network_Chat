// GUIController.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Net.Sockets;
using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller.Client;
using Network_Chat.ProjectSRC.GUI;
using Network_Chat.ProjectSRC.Model;
using Network_Library.Network;
using Network_Library.Network.Messaging;
using Network_Library.Network.Server;
using Message = Network_Library.Network.Messaging.Message;
using ServerSocket = Network_Chat.ProjectSRC.Controller.Server.ServerSocket;

namespace Network_Chat.ProjectSRC.Controller {
    public class GUIController {
        public GUIView View { get; set; }
        public Serializer Serializer { get; private set; }
        public GUIModel Model { get; set; }

        public bool Connected { get; set; }
        private ASocket ClientSocket { get; set; } // Connection to Server if this is Client
        private ServerAcceptor ServerAcceptor { get; set; } //Connection to all Clients if this is Server

        public GUIController(GUIView view) {
            Serializer = new Serializer(this);
            Model = Serializer.Deserialize();
            if(Model == null) Model = new GUIModel();

            View = view;
            View.UpdateView(Model);
        }

        public void Send(object sender, EventArgs e) {
            string text = View.SendString;
            string[] split = text.Split(' ');
            object[] param = ASocket.ShortenArray(split, 1);
            Message mes = new Message(split[0], param);
            if(ClientSocket != null) ClientSocket.Send(mes); //Send to Server
            else ServerAcceptor.BroadcastMessage(mes); //Send to all
        }

        public void JoinServer(string username, string pw, string ip, int port) {
            Connected = true;
            Model.ClientModel.Username = username;
            Model.ClientModel.Password = pw;

            ClientSocket = new ClientSocket(this, ip, port);
            ClientSocket.IncomingMessage += IncomingMessage;
            ClientSocket.UserConnect += UserJoin;
            ClientSocket.UserDisconnect += UserLeave;
            View.AddInfoInfo("Connected to "+ip+":"+port);
        }
        public void CreateServer(string name, int port, int maxPlayer) {
            Connected = true;
            Model.ServerModel.Servername = name;
            Model.ServerModel.MaxPlayer = maxPlayer;
            Model.ServerModel.Port = port;

            ServerAcceptor = new ServerAcceptor(typeof(ServerSocket));
            ServerAcceptor.ServerSocketCreated += ServerSocketCreated;
            ServerAcceptor.OpenServer(port);
            View.AddInfoInfo("Created server with name \""+name+"\"");
            View.AddInfoInfo("Listening to port \""+port+"\"");
        }

        private void ServerSocketCreated(object sender, Network_Library.Network.Server.ServerSocket servSocket) {
            ServerSocket socket = (ServerSocket)servSocket;
            socket.IncomingMessage += IncomingMessage;
            socket.UserConnect += UserJoin;
            socket.UserDisconnect += UserLeave;
        }

        public void IncomingMessage(object sender, string message) {
            Model.MessageList.Add(message);
            View.UpdateView(Model);
        }

        public void UserJoin(object sender, TcpClient client) { 
            //TODO: Add "user" parameter !OR! search user by searching for "client"
            Model.Users.Add(user);
            View.UpdateUserlist(Model);
        }
        public void UserLeave(object sender, TcpClient client) {
            Model.Users.Remove(user);
            View.UpdateUserlist(Model);
        }
    }
}