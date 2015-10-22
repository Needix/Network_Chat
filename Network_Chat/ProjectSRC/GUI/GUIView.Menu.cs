// GUIView.Menu.cs
// Copyright 2015
// 
// Author: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;

namespace Network_Chat.ProjectSRC.GUI {
    public partial class GUIView {
        private void OpenCreateServerForm(object sender, EventArgs e) {
            if (_controller.Connected) return;
            GUICreateServer gui = new GUICreateServer(_controller);
            gui.ShowDialog();
        }
        private void OpenJoinServerForm(object sender, EventArgs e) {
            if(_controller.Connected) return;
            GUIJoinServer gui = new GUIJoinServer(_controller);
            gui.ShowDialog();
        }
        private void ExitForm(object sender, EventArgs e) {

        }
    }
}