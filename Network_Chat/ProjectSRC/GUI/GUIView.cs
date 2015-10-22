// GUIView.cs
// Copyright 2015
// 
// Project Lead: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller;
using Network_Chat.ProjectSRC.Model;

namespace Network_Chat.ProjectSRC.GUI {
    public partial class GUIView : Form {
        private GUIController _controller;

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
            //TODO: Add update code here (update gui components from model data)
        }
    }
}
