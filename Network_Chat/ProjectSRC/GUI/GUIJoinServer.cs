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
    public partial class GUIJoinServer :Form {
        private readonly GUIController _controller;

        public GUIJoinServer(GUIController controller) {
            InitializeComponent();
            RegisterCustomEvents();

            _controller = controller;
        }

        private void RegisterCustomEvents() {
            b_connect.Click += JoinServer;
        }

        private void JoinServer(object sender, EventArgs e) {
            try {
                int port = Convert.ToInt32(tb_serverInfo_port.Text);
                String ip = tb_serverInfo_ip.Text;
                String username = tb_cred_username.Text;
                String pw = tb_cred_password.Text;
                _controller.JoinServer(username, pw, ip, port);
            } catch(FormatException) {

            }
            this.Close();
        }
    }
}
