namespace yaho2
{
    partial class sonucForm
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
            components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sonucForm));
            xButton = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label18 = new Label();
            label8 = new Label();
            label7 = new Label();
            sonskor = new Label();
            label19 = new Label();
            label3 = new Label();
            ipucuskor = new Label();
            label14 = new Label();
            ipucupuanı = new Label();
            ikincioyunskor = new Label();
            birincioyunskor = new Label();
            ikincioyunpuan = new Label();
            kalandenemepuan = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            listView1 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            soundPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)xButton).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).BeginInit();
            SuspendLayout();
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
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(895, 466);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 26;
            button1.Text = "Tekrar Oyna";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(sonskor);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ipucuskor);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(ipucupuanı);
            groupBox1.Controls.Add(ikincioyunskor);
            groupBox1.Controls.Add(birincioyunskor);
            groupBox1.Controls.Add(ikincioyunpuan);
            groupBox1.Controls.Add(kalandenemepuan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(80, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 384);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(250, 139);
            label10.Name = "label10";
            label10.Size = new Size(110, 24);
            label10.TabIndex = 50;
            label10.Text = "kolayzororta";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Visible = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 138);
            label9.Name = "label9";
            label9.Size = new Size(210, 24);
            label9.TabIndex = 49;
            label9.Text = "Seçilen Zorluk Modu";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(231, 325);
            label18.Name = "label18";
            label18.Size = new Size(15, 15);
            label18.TabIndex = 44;
            label18.Text = "+";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            label18.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(250, 304);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 48;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 304);
            label7.Name = "label7";
            label7.Size = new Size(220, 24);
            label7.TabIndex = 47;
            label7.Text = "Zorluk Skoru";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sonskor
            // 
            sonskor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sonskor.ImageAlign = ContentAlignment.MiddleLeft;
            sonskor.Location = new Point(250, 344);
            sonskor.Name = "sonskor";
            sonskor.Size = new Size(44, 24);
            sonskor.TabIndex = 46;
            sonskor.Text = "16000";
            sonskor.TextAlign = ContentAlignment.MiddleLeft;
            sonskor.Visible = false;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.ForeColor = Color.Black;
            label19.Location = new Point(229, 328);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 45;
            label19.Text = "_________________";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            label19.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 264);
            label3.Name = "label3";
            label3.Size = new Size(220, 24);
            label3.TabIndex = 30;
            label3.Text = "İpucu Skoru";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ipucuskor
            // 
            ipucuskor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ipucuskor.ImageAlign = ContentAlignment.MiddleLeft;
            ipucuskor.Location = new Point(250, 264);
            ipucuskor.Name = "ipucuskor";
            ipucuskor.Size = new Size(38, 24);
            ipucuskor.TabIndex = 36;
            ipucuskor.Text = "label9";
            ipucuskor.TextAlign = ContentAlignment.MiddleCenter;
            ipucuskor.Visible = false;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(24, 64);
            label14.Name = "label14";
            label14.Size = new Size(200, 24);
            label14.TabIndex = 41;
            label14.Text = "İpucu Kullanımı";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ipucupuanı
            // 
            ipucupuanı.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ipucupuanı.ImageAlign = ContentAlignment.MiddleLeft;
            ipucupuanı.Location = new Point(250, 64);
            ipucupuanı.Name = "ipucupuanı";
            ipucupuanı.Size = new Size(58, 24);
            ipucupuanı.TabIndex = 40;
            ipucupuanı.Text = "evet hayır";
            ipucupuanı.TextAlign = ContentAlignment.MiddleCenter;
            ipucupuanı.Visible = false;
            // 
            // ikincioyunskor
            // 
            ikincioyunskor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ikincioyunskor.ImageAlign = ContentAlignment.MiddleLeft;
            ikincioyunskor.Location = new Point(250, 224);
            ikincioyunskor.Name = "ikincioyunskor";
            ikincioyunskor.Size = new Size(44, 24);
            ikincioyunskor.TabIndex = 39;
            ikincioyunskor.Text = "label12";
            ikincioyunskor.TextAlign = ContentAlignment.MiddleCenter;
            ikincioyunskor.Visible = false;
            // 
            // birincioyunskor
            // 
            birincioyunskor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            birincioyunskor.ImageAlign = ContentAlignment.MiddleLeft;
            birincioyunskor.Location = new Point(250, 184);
            birincioyunskor.Name = "birincioyunskor";
            birincioyunskor.Size = new Size(44, 24);
            birincioyunskor.TabIndex = 38;
            birincioyunskor.Text = "label11";
            birincioyunskor.TextAlign = ContentAlignment.MiddleCenter;
            birincioyunskor.Visible = false;
            // 
            // ikincioyunpuan
            // 
            ikincioyunpuan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ikincioyunpuan.ImageAlign = ContentAlignment.MiddleLeft;
            ikincioyunpuan.Location = new Point(250, 104);
            ikincioyunpuan.Name = "ikincioyunpuan";
            ikincioyunpuan.Size = new Size(110, 24);
            ikincioyunpuan.TabIndex = 37;
            ikincioyunpuan.Text = "edoğru sayısı x 500";
            ikincioyunpuan.TextAlign = ContentAlignment.MiddleLeft;
            ikincioyunpuan.Visible = false;
            // 
            // kalandenemepuan
            // 
            kalandenemepuan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kalandenemepuan.ImageAlign = ContentAlignment.MiddleLeft;
            kalandenemepuan.Location = new Point(250, 25);
            kalandenemepuan.Name = "kalandenemepuan";
            kalandenemepuan.Size = new Size(110, 24);
            kalandenemepuan.TabIndex = 35;
            kalandenemepuan.Text = "(deneme+1).1000";
            kalandenemepuan.TextAlign = ContentAlignment.MiddleLeft;
            kalandenemepuan.Visible = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 224);
            label5.Name = "label5";
            label5.Size = new Size(220, 24);
            label5.TabIndex = 32;
            label5.Text = "2. Oyundan Alınan Toplam Skor";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 184);
            label4.Name = "label4";
            label4.Size = new Size(220, 24);
            label4.TabIndex = 31;
            label4.Text = "1. Oyundan Alınan Toplam Skor";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 104);
            label1.Name = "label1";
            label1.Size = new Size(210, 24);
            label1.TabIndex = 28;
            label1.Text = "2. Oyunda Yapılan Doğru Sayısı";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 24);
            label2.Name = "label2";
            label2.Size = new Size(220, 24);
            label2.TabIndex = 29;
            label2.Text = "1. Oyun Kalan Deneme Hakkı";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(214, 485);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(152, 22);
            progressBar1.TabIndex = 28;
            progressBar1.Visible = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(680, 121);
            label6.Name = "label6";
            label6.Size = new Size(128, 24);
            label6.TabIndex = 29;
            label6.Text = "SON 10 OYUN";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
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
            listView1.Location = new Point(544, 162);
            listView1.Name = "listView1";
            listView1.Size = new Size(400, 220);
            listView1.TabIndex = 30;
            listView1.TileSize = new Size(10, 10);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Visible = false;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "";
            columnHeader3.Width = 32;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kullanıcı Adı";
            columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Toplam Skor";
            columnHeader2.Width = 182;
            // 
            // soundPictureBox
            // 
            soundPictureBox.BackColor = Color.Transparent;
            soundPictureBox.Image = Properties.Resources.sound_on;
            soundPictureBox.Location = new Point(968, 520);
            soundPictureBox.Name = "soundPictureBox";
            soundPictureBox.Size = new Size(40, 40);
            soundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            soundPictureBox.TabIndex = 31;
            soundPictureBox.TabStop = false;
            soundPictureBox.Click += soundPictureBox_Click;
            // 
            // sonucForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 576);
            Controls.Add(groupBox1);
            Controls.Add(soundPictureBox);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(xButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "sonucForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += sonucForm_Load;
            ((System.ComponentModel.ISupportInitialize)xButton).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox xButton;
        private Button button1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label14;
        private Label ipucupuanı;
        private Label ikincioyunskor;
        private Label birincioyunskor;
        private Label ikincioyunpuan;
        private Label ipucuskor;
        private Label kalandenemepuan;
        private Label sonskor;
        private Label label18;
        private Label label19;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox soundPictureBox;
        private ColumnHeader columnHeader3;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
    }
}