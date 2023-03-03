namespace EsoftProject
{
    partial class clients
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputs2 = new EsoftProject.UI.inputs();
            this.buttons4 = new EsoftProject.UI.buttons();
            this.buttons3 = new EsoftProject.UI.buttons();
            this.buttons2 = new EsoftProject.UI.buttons();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.error_log = new System.Windows.Forms.Label();
            this.inputs1 = new EsoftProject.UI.inputs();
            this.buttons1 = new EsoftProject.UI.buttons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EsoftProject.Properties.Resources.logo_wr;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(282, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 406);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.inputs2);
            this.panel1.Controls.Add(this.buttons4);
            this.panel1.Controls.Add(this.buttons3);
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 549);
            this.panel1.TabIndex = 4;
            // 
            // inputs2
            // 
            this.inputs2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(73)))), ((int)(((byte)(91)))));
            this.inputs2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(73)))), ((int)(((byte)(91)))));
            this.inputs2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.inputs2.BorderRadius = 3;
            this.inputs2.BorderSize = 2;
            this.inputs2.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputs2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.inputs2.Location = new System.Drawing.Point(10, 56);
            this.inputs2.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.inputs2.Multiline = false;
            this.inputs2.Name = "inputs2";
            this.inputs2.Padding = new System.Windows.Forms.Padding(10);
            this.inputs2.PasswordChar = false;
            this.inputs2.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.inputs2.PlaceholderText = "Фильтр по названию";
            this.inputs2.Size = new System.Drawing.Size(256, 36);
            this.inputs2.TabIndex = 7;
            this.inputs2.Texts = "";
            this.inputs2.UnderlinedStyle = false;
            // 
            // buttons4
            // 
            this.buttons4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons4.BorderRadius = 0;
            this.buttons4.BorderSize = 0;
            this.buttons4.FlatAppearance.BorderSize = 0;
            this.buttons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons4.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttons4.ForeColor = System.Drawing.Color.White;
            this.buttons4.Location = new System.Drawing.Point(0, 158);
            this.buttons4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttons4.Name = "buttons4";
            this.buttons4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttons4.Size = new System.Drawing.Size(276, 42);
            this.buttons4.TabIndex = 9;
            this.buttons4.Text = "Изменить";
            this.buttons4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttons4.TextColor = System.Drawing.Color.White;
            this.buttons4.UseVisualStyleBackColor = false;
            this.buttons4.Click += new System.EventHandler(this.buttons4_Click);
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons3.BorderRadius = 0;
            this.buttons3.BorderSize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttons3.ForeColor = System.Drawing.Color.White;
            this.buttons3.Location = new System.Drawing.Point(0, 210);
            this.buttons3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttons3.Name = "buttons3";
            this.buttons3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttons3.Size = new System.Drawing.Size(276, 42);
            this.buttons3.TabIndex = 8;
            this.buttons3.Text = "Удалить";
            this.buttons3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttons3.TextColor = System.Drawing.Color.White;
            this.buttons3.UseVisualStyleBackColor = false;
            this.buttons3.Click += new System.EventHandler(this.buttons3_Click);
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttons2.BorderRadius = 0;
            this.buttons2.BorderSize = 0;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Location = new System.Drawing.Point(0, 106);
            this.buttons2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttons2.Size = new System.Drawing.Size(276, 42);
            this.buttons2.TabIndex = 7;
            this.buttons2.Text = "Добавить";
            this.buttons2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            this.buttons2.MouseLeave += new System.EventHandler(this.buttons2_MouseLeave);
            this.buttons2.MouseHover += new System.EventHandler(this.buttons2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(282, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Клиенты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "В данном окне вы можете просмотреть информацию о клиентах, а так же изменить её. " +
    "При необходимости - удалить";
            // 
            // error_log
            // 
            this.error_log.AutoSize = true;
            this.error_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.error_log.Location = new System.Drawing.Point(290, 108);
            this.error_log.Name = "error_log";
            this.error_log.Size = new System.Drawing.Size(38, 13);
            this.error_log.TabIndex = 7;
            this.error_log.Text = "label2";
            this.error_log.Visible = false;
            // 
            // inputs1
            // 
            this.inputs1.BackColor = System.Drawing.Color.White;
            this.inputs1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.inputs1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.inputs1.BorderRadius = 3;
            this.inputs1.BorderSize = 2;
            this.inputs1.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.inputs1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.inputs1.Location = new System.Drawing.Point(289, 70);
            this.inputs1.Margin = new System.Windows.Forms.Padding(4);
            this.inputs1.Multiline = false;
            this.inputs1.Name = "inputs1";
            this.inputs1.Padding = new System.Windows.Forms.Padding(10);
            this.inputs1.PasswordChar = false;
            this.inputs1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.inputs1.PlaceholderText = "Введите для поиска";
            this.inputs1.Size = new System.Drawing.Size(286, 34);
            this.inputs1.TabIndex = 2;
            this.inputs1.Texts = "";
            this.inputs1.UnderlinedStyle = false;
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
            this.buttons1.Location = new System.Drawing.Point(582, 70);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(93, 34);
            this.buttons1.TabIndex = 1;
            this.buttons1.Text = "Поиск";
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // clients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 549);
            this.Controls.Add(this.error_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputs1);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "clients";
            this.Text = "Esoft - Клиенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UI.buttons buttons1;
        private EsoftProject.UI.inputs inputs1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private UI.buttons buttons2;
        private UI.inputs inputs2;
        private UI.buttons buttons4;
        private UI.buttons buttons3;
        private System.Windows.Forms.Label error_log;
    }
}

