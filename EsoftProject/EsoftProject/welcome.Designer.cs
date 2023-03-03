namespace EsoftProject
{
    partial class welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error_log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_enter = new EsoftProject.UI.inputs();
            this.buttons1 = new EsoftProject.UI.buttons();
            this.password_enter = new EsoftProject.UI.inputs();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.client = new CustomControls.RJControls.r_buttons();
            this.agent = new CustomControls.RJControls.r_buttons();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Логин";
            // 
            // error_log
            // 
            this.error_log.AutoSize = true;
            this.error_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.error_log.Location = new System.Drawing.Point(83, 236);
            this.error_log.Name = "error_log";
            this.error_log.Size = new System.Drawing.Size(38, 13);
            this.error_log.TabIndex = 17;
            this.error_log.Text = "label2";
            this.error_log.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(151, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Нет аккаунта?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1010, 539);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "v 1.0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 562);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "kaurcev dev - Все права защищены 2023";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.linkLabel1.Location = new System.Drawing.Point(886, 562);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://beta.kaurcev.tk/esoft";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.client);
            this.panel1.Controls.Add(this.agent);
            this.panel1.Controls.Add(this.login_enter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttons1);
            this.panel1.Controls.Add(this.password_enter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.error_log);
            this.panel1.Location = new System.Drawing.Point(332, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 362);
            this.panel1.TabIndex = 24;
            // 
            // login_enter
            // 
            this.login_enter.BackColor = System.Drawing.Color.White;
            this.login_enter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.login_enter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.login_enter.BorderRadius = 3;
            this.login_enter.BorderSize = 2;
            this.login_enter.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.login_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.login_enter.Location = new System.Drawing.Point(84, 136);
            this.login_enter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.login_enter.Multiline = false;
            this.login_enter.Name = "login_enter";
            this.login_enter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.login_enter.PasswordChar = false;
            this.login_enter.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.login_enter.PlaceholderText = "";
            this.login_enter.Size = new System.Drawing.Size(222, 34);
            this.login_enter.TabIndex = 13;
            this.login_enter.Tag = "";
            this.login_enter.Texts = "";
            this.login_enter.UnderlinedStyle = false;
            this.login_enter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_enter_KeyPress);
            this.login_enter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_enter_MouseClick);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttons1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttons1.BorderRadius = 3;
            this.buttons1.BorderSize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(84, 260);
            this.buttons1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(222, 34);
            this.buttons1.TabIndex = 12;
            this.buttons1.Text = "Войти";
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // password_enter
            // 
            this.password_enter.BackColor = System.Drawing.Color.White;
            this.password_enter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.password_enter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.password_enter.BorderRadius = 3;
            this.password_enter.BorderSize = 2;
            this.password_enter.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.password_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.password_enter.Location = new System.Drawing.Point(84, 198);
            this.password_enter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password_enter.Multiline = false;
            this.password_enter.Name = "password_enter";
            this.password_enter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.password_enter.PasswordChar = false;
            this.password_enter.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.password_enter.PlaceholderText = "";
            this.password_enter.Size = new System.Drawing.Size(222, 34);
            this.password_enter.TabIndex = 15;
            this.password_enter.Texts = "";
            this.password_enter.UnderlinedStyle = false;
            this.password_enter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_enter_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EsoftProject.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(86, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImage = global::EsoftProject.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(16, 539);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 18);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.client.Location = new System.Drawing.Point(117, 95);
            this.client.MinimumSize = new System.Drawing.Size(0, 21);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.client.Size = new System.Drawing.Size(74, 21);
            this.client.TabIndex = 34;
            this.client.TabStop = true;
            this.client.Text = "Клиент";
            this.client.UnCheckedColor = System.Drawing.Color.Gray;
            this.client.UseVisualStyleBackColor = true;
            // 
            // agent
            // 
            this.agent.AutoSize = true;
            this.agent.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.agent.Location = new System.Drawing.Point(197, 95);
            this.agent.MinimumSize = new System.Drawing.Size(0, 21);
            this.agent.Name = "agent";
            this.agent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.agent.Size = new System.Drawing.Size(80, 21);
            this.agent.TabIndex = 35;
            this.agent.TabStop = true;
            this.agent.Text = "Риелтор";
            this.agent.UnCheckedColor = System.Drawing.Color.Gray;
            this.agent.UseVisualStyleBackColor = true;
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(430, 450);
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft - Добро пожаловать";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.welcome_FormClosed);
            this.Load += new System.EventHandler(this.welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private UI.inputs password_enter;
        private System.Windows.Forms.Label label2;
        private UI.inputs login_enter;
        private UI.buttons buttons1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label error_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.r_buttons client;
        private CustomControls.RJControls.r_buttons agent;
    }
}