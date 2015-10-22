// GUIView.ChatBox.cs
// Copyright 2015
// 
// Author: Need
// Contact:      
//     Mail:     mailto:needdragon@gmail.com 
//     Twitter: https://twitter.com/NeedDragon

using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Network_Chat.ProjectSRC.GUI {
    public partial class GUIView {
        public void AddErrorInfo(String text) {
            AddInfo(text, Color.Red);
        }

        public void AddInfoInfo(String text) {
            AddInfo(text, Color.White);
        }

        public void AddWarningInfo(String text) {
            AddInfo(text, Color.Orange);
        }

        private void AddInfo(String text, Color color) {
            if(!this.IsHandleCreated) {
                Debug.WriteLine("ERROR: GUI| Trying to add \""+text+"\" to ListViewInfo while handle is invalid!");
                return;
            }
            try {
                this.listView_chatbox.Invoke((MethodInvoker)delegate {
                    listView_chatbox.Items.Add(DateTime.Now + ": " + text);
                    ListViewItem item = listView_chatbox.Items[listView_chatbox.Items.Count - 1];
                    item.BackColor = color;
                    listView_chatbox.EnsureVisible(listView_chatbox.Items.Count - 1);
                    listView_chatbox.Columns[0].Width = -1;
                });
            } catch(ThreadInterruptedException) { }
        }
    }
}