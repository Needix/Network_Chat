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

namespace Network_Chat.ProjectSRC.Controller {
    public class GUIController {
        public GUIView View { get; set; }
        public Serializer Serializer { get; private set; }
        public GUIModel Model { get; set; }

        public Boolean Connected { get; set; }
        private ASocket ClientSocket { get; set; }
        private ServerAcceptor ServerAcceptor { get; set; }

        public GUIController(GUIView view) {
            Serializer = new Serializer(this);
            Model = Serializer.Deserialize();
            if(Model == null) Model = new GUIModel();

            View = view;
            View.UpdateView(Model);
        }

        public void Send(object sender, EventArgs e) {
            String text = ((TextBox) View.Controls["tb_chatToSend"]).Text;
            String[] split = text.Split(' ');
            if(ClientSocket!=null) ClientSocket.Send(new Network_Library.Network.Messaging.Message(text));
        }

        public void JoinServer(String username, String pw, String ip, int port) {
            Connected = true;
            Model.ClientModel.Username = username;
            Model.ClientModel.Password = pw;

            ClientSocket = new ClientSocket(ip, port);
        }

        public void CreateServer(String name, int port, int maxPlayer) {
            Connected = true;
            Model.ServerModel.Servername = name;
            Model.ServerModel.MaxPlayer = maxPlayer;
            Model.ServerModel.Port = port;

            ServerAcceptor = new ServerAcceptor(typeof(ServerSocket));
            ServerAcceptor.OpenServer(port);
        }
    }
}