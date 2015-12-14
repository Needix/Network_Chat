// GUIView.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller;
using Network_Chat.ProjectSRC.Model;

namespace Network_Chat.ProjectSRC.GUI {
    public partial class GUIView : Form {
        private GUIController _controller;
        public String SendString { get { return tb_chatToSend.Text; } }

        public GUIView() {
            InitializeComponent();
        }

        private void RegisterCustomEvents() {
            b_chat_send.Click += _controller.Send;

            menu_createServer.Click += OpenCreateServerForm;
            menu_joinServer.Click += OpenJoinServerForm;
            menu_exit.Click += ExitForm;
            Closing += ExitForm;
        }

        public void RegisterController(GUIController controller) {
            _controller = controller;
            RegisterCustomEvents();
        }

        public void UpdateView(GUIModel model) {
            UpdateChatbox(model);
            UpdateUserlist(model);
        }

        public void UpdateUserlist(GUIModel model) {
            listBox_user_users.Items.Clear();
            foreach(User s in model.Users) {
                listBox_user_users.Items.Add(s.Username);
            }
        }

        public void UpdateChatbox(GUIModel model) {
            listView_chatbox.Items.Clear();
            foreach(string s in model.MessageList) {
                listView_chatbox.Items.Add(s);
            }
        }
    }
}
