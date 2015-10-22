namespace Network_Chat.ProjectSRC.GUI {
    partial class GUICreateServer {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_createServer = new System.Windows.Forms.Button();
            this.tb_serverInfo_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_servername = new System.Windows.Forms.TextBox();
            this.tb_maxUsers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_maxUsers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_servername);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.b_createServer);
            this.groupBox2.Controls.Add(this.tb_serverInfo_port);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 317);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Information";
            // 
            // b_createServer
            // 
            this.b_createServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_createServer.Location = new System.Drawing.Point(672, 288);
            this.b_createServer.Name = "b_createServer";
            this.b_createServer.Size = new System.Drawing.Size(102, 23);
            this.b_createServer.TabIndex = 4;
            this.b_createServer.Text = "Create Server";
            this.b_createServer.UseVisualStyleBackColor = true;
            // 
            // tb_serverInfo_port
            // 
            this.tb_serverInfo_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_serverInfo_port.Location = new System.Drawing.Point(173, 23);
            this.tb_serverInfo_port.Name = "tb_serverInfo_port";
            this.tb_serverInfo_port.Size = new System.Drawing.Size(601, 20);
            this.tb_serverInfo_port.TabIndex = 3;
            this.tb_serverInfo_port.Text = "5780";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servername: ";
            // 
            // tb_servername
            // 
            this.tb_servername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_servername.Location = new System.Drawing.Point(173, 49);
            this.tb_servername.Name = "tb_servername";
            this.tb_servername.Size = new System.Drawing.Size(601, 20);
            this.tb_servername.TabIndex = 6;
            this.tb_servername.Text = "My Chat Server";
            // 
            // tb_maxUsers
            // 
            this.tb_maxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_maxUsers.Location = new System.Drawing.Point(173, 77);
            this.tb_maxUsers.Name = "tb_maxUsers";
            this.tb_maxUsers.Size = new System.Drawing.Size(601, 20);
            this.tb_maxUsers.TabIndex = 8;
            this.tb_maxUsers.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max Users (-1 for infinite): ";
            // 
            // GUICreateServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 317);
            this.Controls.Add(this.groupBox2);
            this.Name = "GUICreateServer";
            this.Text = "GUICreateServer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_createServer;
        private System.Windows.Forms.TextBox tb_serverInfo_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_maxUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_servername;
        private System.Windows.Forms.Label label1;
    }
}