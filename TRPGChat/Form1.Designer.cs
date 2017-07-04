namespace TRPGChat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.stb_roomname = new System.Windows.Forms.TextBox();
            this.stb_username = new System.Windows.Forms.TextBox();
            this.stb_port = new System.Windows.Forms.TextBox();
            this.stb_ip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TabPage();
            this.cardmanager = new System.Windows.Forms.TabPage();
            this.set = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.room);
            this.tabControl1.Controls.Add(this.cardmanager);
            this.tabControl1.Controls.Add(this.set);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 395);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // login
            // 
            this.login.Controls.Add(this.label11);
            this.login.Controls.Add(this.checkBox1);
            this.login.Controls.Add(this.label6);
            this.login.Controls.Add(this.stb_roomname);
            this.login.Controls.Add(this.stb_username);
            this.login.Controls.Add(this.stb_port);
            this.login.Controls.Add(this.stb_ip);
            this.login.Controls.Add(this.button2);
            this.login.Controls.Add(this.label7);
            this.login.Controls.Add(this.label8);
            this.login.Controls.Add(this.label9);
            this.login.Controls.Add(this.label10);
            this.login.Controls.Add(this.label5);
            this.login.Controls.Add(this.textBox4);
            this.login.Controls.Add(this.textBox3);
            this.login.Controls.Add(this.textBox2);
            this.login.Controls.Add(this.textBox1);
            this.login.Controls.Add(this.button1);
            this.login.Controls.Add(this.label4);
            this.login.Controls.Add(this.label3);
            this.login.Controls.Add(this.label2);
            this.login.Controls.Add(this.label1);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(734, 369);
            this.login.TabIndex = 0;
            this.login.Text = "登陆/开团";
            this.login.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "---------------服务端-----------------------------------";
            // 
            // stb_roomname
            // 
            this.stb_roomname.Location = new System.Drawing.Point(47, 251);
            this.stb_roomname.Name = "stb_roomname";
            this.stb_roomname.Size = new System.Drawing.Size(162, 21);
            this.stb_roomname.TabIndex = 18;
            // 
            // stb_username
            // 
            this.stb_username.Location = new System.Drawing.Point(47, 218);
            this.stb_username.Name = "stb_username";
            this.stb_username.Size = new System.Drawing.Size(162, 21);
            this.stb_username.TabIndex = 17;
            // 
            // stb_port
            // 
            this.stb_port.Location = new System.Drawing.Point(262, 188);
            this.stb_port.Name = "stb_port";
            this.stb_port.Text = "1001";
            this.stb_port.Size = new System.Drawing.Size(85, 21);
            this.stb_port.TabIndex = 16;
            // 
            // stb_ip
            // 
            this.stb_ip.Location = new System.Drawing.Point(47, 188);
            this.stb_ip.Name = "stb_ip";
            this.stb_ip.Text = "";
            this.stb_ip.Size = new System.Drawing.Size(162, 21);
            this.stb_ip.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "创建";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "端口号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "房间名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "用户名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "主机IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "---------------客户端-----------------------------------";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(47, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 21);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "端口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机IP";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(4, 22);
            this.room.Name = "room";
            this.room.Padding = new System.Windows.Forms.Padding(3);
            this.room.Size = new System.Drawing.Size(734, 369);
            this.room.TabIndex = 1;
            this.room.Text = "房间";
            this.room.UseVisualStyleBackColor = true;
            // 
            // cardmanager
            // 
            this.cardmanager.Location = new System.Drawing.Point(4, 22);
            this.cardmanager.Name = "cardmanager";
            this.cardmanager.Size = new System.Drawing.Size(734, 369);
            this.cardmanager.TabIndex = 2;
            this.cardmanager.Text = "卡牌管理";
            this.cardmanager.UseVisualStyleBackColor = true;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(4, 22);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(734, 369);
            this.set.TabIndex = 3;
            this.set.Text = "设置";
            this.set.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "是否使用路由器";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 395);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.TabPage room;
        private System.Windows.Forms.TabPage cardmanager;
        private System.Windows.Forms.TabPage set;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox stb_roomname;
        public System.Windows.Forms.TextBox stb_username;
        public System.Windows.Forms.TextBox stb_port;
        public System.Windows.Forms.TextBox stb_ip;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label label11;
    }
}

