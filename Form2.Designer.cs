namespace yaho2
{
    partial class oyunBirForm
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "") }, "(yok)");
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "", "", "", "", "", "" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyunBirForm));
            oyun1Puan = new Label();
            comboBox1 = new ComboBox();
            soundPictureBox = new PictureBox();
            xButton = new PictureBox();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            hak = new Label();
            oyun_skor = new Label();
            label2 = new Label();
            oyun1_ilerle_button = new Button();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // oyun1Puan
            // 
            oyun1Puan.AutoSize = true;
            oyun1Puan.Location = new Point(21, 16);
            oyun1Puan.Name = "oyun1Puan";
            oyun1Puan.Size = new Size(42, 15);
            oyun1Puan.TabIndex = 18;
            oyun1Puan.Text = "Skor..: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 19;
            // 
            // soundPictureBox
            // 
            soundPictureBox.BackColor = Color.Transparent;
            soundPictureBox.Image = Properties.Resources.sound_on;
            soundPictureBox.Location = new Point(968, 520);
            soundPictureBox.Name = "soundPictureBox";
            soundPictureBox.Size = new Size(40, 40);
            soundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            soundPictureBox.TabIndex = 20;
            soundPictureBox.TabStop = false;
            soundPictureBox.Click += soundPictureBox_Click;
            // 
            // xButton
            // 
            xButton.BackColor = Color.Transparent;
            xButton.Image = Properties.Resources.x_mark;
            xButton.Location = new Point(968, 16);
            xButton.Name = "xButton";
            xButton.Size = new Size(40, 40);
            xButton.SizeMode = PictureBoxSizeMode.Zoom;
            xButton.TabIndex = 21;
            xButton.TabStop = false;
            xButton.Click += xButton_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(472, 136);
            button1.Name = "button1";
            button1.Size = new Size(80, 24);
            button1.TabIndex = 23;
            button1.Text = "ONAYLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.ImeMode = ImeMode.NoControl;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            listViewItem3.UseItemStyleForSubItems = false;
            listViewItem4.UseItemStyleForSubItems = false;
            listViewItem5.UseItemStyleForSubItems = false;
            listViewItem6.UseItemStyleForSubItems = false;
            listViewItem7.UseItemStyleForSubItems = false;
            listViewItem8.UseItemStyleForSubItems = false;
            listViewItem9.UseItemStyleForSubItems = false;
            listViewItem10.UseItemStyleForSubItems = false;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            listView1.Location = new Point(0, 226);
            listView1.Name = "listView1";
            listView1.Size = new Size(1025, 218);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Futbolcu Adı";
            columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Forma No";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mevki";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kulüp Takımı";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Milli Takım";
            columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yaş";
            columnHeader6.Width = 166;
            // 
            // hak
            // 
            hak.BackColor = Color.Transparent;
            hak.ForeColor = Color.White;
            hak.Location = new Point(173, 112);
            hak.Name = "hak";
            hak.Size = new Size(48, 16);
            hak.TabIndex = 25;
            hak.Text = "hak";
            hak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oyun_skor
            // 
            oyun_skor.BackColor = Color.Transparent;
            oyun_skor.ForeColor = Color.White;
            oyun_skor.Location = new Point(795, 112);
            oyun_skor.Name = "oyun_skor";
            oyun_skor.Size = new Size(64, 16);
            oyun_skor.TabIndex = 26;
            oyun_skor.Text = "16000";
            oyun_skor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(446, 20);
            label2.Name = "label2";
            label2.Size = new Size(132, 24);
            label2.TabIndex = 27;
            label2.Text = "OYUNCU ADI";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // oyun1_ilerle_button
            // 
            oyun1_ilerle_button.FlatStyle = FlatStyle.System;
            oyun1_ilerle_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oyun1_ilerle_button.Location = new Point(895, 466);
            oyun1_ilerle_button.Name = "oyun1_ilerle_button";
            oyun1_ilerle_button.Size = new Size(113, 41);
            oyun1_ilerle_button.TabIndex = 28;
            oyun1_ilerle_button.Text = "İleri -->";
            oyun1_ilerle_button.UseVisualStyleBackColor = true;
            oyun1_ilerle_button.Visible = false;
            oyun1_ilerle_button.Click += ilerle_button_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(100, 498);
            label3.Name = "label3";
            label3.Size = new Size(230, 24);
            label3.TabIndex = 29;
            label3.Text = "Aradığınız futbolcunun forma numarası = ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(330, 498);
            label4.Name = "label4";
            label4.Size = new Size(180, 24);
            label4.TabIndex = 30;
            label4.Text = "hint";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(32, 498);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 24);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "İpucu";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(432, 52);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(462, 64);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 33;
            label5.Text = "Futbolcu Seç";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(119, 80);
            label6.Name = "label6";
            label6.Size = new Size(156, 24);
            label6.TabIndex = 34;
            label6.Text = "Kalan Deneme Hakkı";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(795, 80);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 35;
            label7.Text = "Puan";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oyunBirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 576);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(oyun1_ilerle_button);
            Controls.Add(label2);
            Controls.Add(oyun_skor);
            Controls.Add(hak);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(xButton);
            Controls.Add(soundPictureBox);
            Controls.Add(comboBox1);
            Controls.Add(oyun1Puan);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "oyunBirForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += oyunBirForm_Load;
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)xButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label oyun1Puan;
        private ComboBox comboBox1;
        private PictureBox soundPictureBox;
        private PictureBox xButton;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label hak;
        private Label label2;
        private Button oyun1_ilerle_button;
        public Label oyun_skor;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}