namespace Network_Chat.ProjectSRC.GUI {
    partial class GUIView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer_main_chat_user = new System.Windows.Forms.SplitContainer();
            this.splitContainer_main_messages_chat = new System.Windows.Forms.SplitContainer();
            this.listView_chatbox = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_createServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_joinServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.b_chat_send = new System.Windows.Forms.Button();
            this.tb_chatToSend = new System.Windows.Forms.TextBox();
            this.listBox_user_users = new System.Windows.Forms.ListBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main_chat_user)).BeginInit();
            this.splitContainer_main_chat_user.Panel1.SuspendLayout();
            this.splitContainer_main_chat_user.Panel2.SuspendLayout();
            this.splitContainer_main_chat_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main_messages_chat)).BeginInit();
            this.splitContainer_main_messages_chat.Panel1.SuspendLayout();
            this.splitContainer_main_messages_chat.Panel2.SuspendLayout();
            this.splitContainer_main_messages_chat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_main_chat_user
            // 
            this.splitContainer_main_chat_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main_chat_user.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main_chat_user.Name = "splitContainer_main_chat_user";
            // 
            // splitContainer_main_chat_user.Panel1
            // 
            this.splitContainer_main_chat_user.Panel1.Controls.Add(this.splitContainer_main_messages_chat);
            // 
            // splitContainer_main_chat_user.Panel2
            // 
            this.splitContainer_main_chat_user.Panel2.Controls.Add(this.listBox_user_users);
            this.splitContainer_main_chat_user.Size = new System.Drawing.Size(944, 474);
            this.splitContainer_main_chat_user.SplitterDistance = 764;
            this.splitContainer_main_chat_user.TabIndex = 0;
            // 
            // splitContainer_main_messages_chat
            // 
            this.splitContainer_main_messages_chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main_messages_chat.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main_messages_chat.Name = "splitContainer_main_messages_chat";
            this.splitContainer_main_messages_chat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main_messages_chat.Panel1
            // 
            this.splitContainer_main_messages_chat.Panel1.Controls.Add(this.listView_chatbox);
            this.splitContainer_main_messages_chat.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer_main_messages_chat.Panel2
            // 
            this.splitContainer_main_messages_chat.Panel2.Controls.Add(this.b_chat_send);
            this.splitContainer_main_messages_chat.Panel2.Controls.Add(this.tb_chatToSend);
            this.splitContainer_main_messages_chat.Size = new System.Drawing.Size(764, 474);
            this.splitContainer_main_messages_chat.SplitterDistance = 439;
            this.splitContainer_main_messages_chat.TabIndex = 0;
            // 
            // listView_chatbox
            // 
            this.listView_chatbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_chatbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_chatbox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_chatbox.Location = new System.Drawing.Point(0, 24);
            this.listView_chatbox.Name = "listView_chatbox";
            this.listView_chatbox.Size = new System.Drawing.Size(764, 415);
            this.listView_chatbox.TabIndex = 2;
            this.listView_chatbox.UseCompatibleStateImageBehavior = false;
            this.listView_chatbox.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_createServer,
            this.menu_joinServer,
            this.toolStripSeparator1,
            this.menu_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_createServer
            // 
            this.menu_createServer.Name = "menu_createServer";
            this.menu_createServer.Size = new System.Drawing.Size(152, 22);
            this.menu_createServer.Text = "Create Server...";
            // 
            // menu_joinServer
            // 
            this.menu_joinServer.Name = "menu_joinServer";
            this.menu_joinServer.Size = new System.Drawing.Size(152, 22);
            this.menu_joinServer.Text = "Join Server";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(152, 22);
            this.menu_exit.Text = "Exit";
            // 
            // b_chat_send
            // 
            this.b_chat_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_chat_send.Location = new System.Drawing.Point(689, 2);
            this.b_chat_send.Name = "b_chat_send";
            this.b_chat_send.Size = new System.Drawing.Size(75, 26);
            this.b_chat_send.TabIndex = 1;
            this.b_chat_send.Text = "Send";
            this.b_chat_send.UseVisualStyleBackColor = true;
            // 
            // tb_chatToSend
            // 
            this.tb_chatToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_chatToSend.Location = new System.Drawing.Point(3, 3);
            this.tb_chatToSend.Multiline = true;
            this.tb_chatToSend.Name = "tb_chatToSend";
            this.tb_chatToSend.Size = new System.Drawing.Size(683, 25);
            this.tb_chatToSend.TabIndex = 0;
            // 
            // listBox_user_users
            // 
            this.listBox_user_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_user_users.FormattingEnabled = true;
            this.listBox_user_users.Location = new System.Drawing.Point(0, 0);
            this.listBox_user_users.Name = "listBox_user_users";
            this.listBox_user_users.Size = new System.Drawing.Size(176, 474);
            this.listBox_user_users.TabIndex = 0;
            // 
            // GUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 474);
            this.Controls.Add(this.splitContainer_main_chat_user);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIView";
            this.Text = "GUIView";
            this.splitContainer_main_chat_user.Panel1.ResumeLayout(false);
            this.splitContainer_main_chat_user.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main_chat_user)).EndInit();
            this.splitContainer_main_chat_user.ResumeLayout(false);
            this.splitContainer_main_messages_chat.Panel1.ResumeLayout(false);
            this.splitContainer_main_messages_chat.Panel1.PerformLayout();
            this.splitContainer_main_messages_chat.Panel2.ResumeLayout(false);
            this.splitContainer_main_messages_chat.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main_messages_chat)).EndInit();
            this.splitContainer_main_messages_chat.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_main_chat_user;
        private System.Windows.Forms.SplitContainer splitContainer_main_messages_chat;
        private System.Windows.Forms.TextBox tb_chatToSend;
        private System.Windows.Forms.ListBox listBox_user_users;
        private System.Windows.Forms.Button b_chat_send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_createServer;
        private System.Windows.Forms.ToolStripMenuItem menu_joinServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ListView listView_chatbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}