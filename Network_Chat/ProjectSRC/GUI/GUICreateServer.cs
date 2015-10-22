using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller;

namespace Network_Chat.ProjectSRC.GUI {
    public partial class GUICreateServer :Form {
        private readonly GUIController _controller;

        public GUICreateServer(GUIController controller) {
            InitializeComponent();
            RegisterCustomEvents();

            _controller = controller;
        }

        private void RegisterCustomEvents() {
            b_createServer.Click += CreateServer;
        }

        private void CreateServer(object sender, EventArgs e) {
            try {
                int port = Convert.ToInt32(tb_serverInfo_port.Text);
                int maxPlayer = Convert.ToInt32(tb_maxUsers.Text);
                String name = tb_servername.Text;
                _controller.CreateServer(name, port, maxPlayer);
            } catch (FormatException) {
                
            }
            this.Close();
        }
    }
}
