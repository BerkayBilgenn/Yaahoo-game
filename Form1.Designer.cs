namespace yaho2
{
    partial class girisSayfasiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisSayfasiForm));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "------", "------" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "------", "------" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "3", "------", "------" }, -1);
            oyunBilgisiIkon = new PictureBox();
            xButton = new PictureBox();
            oyunBilgiEtiket = new Label();
            label3 = new Label();
            listView1 = new ListView();
            Tier = new ColumnHeader();
            nickName = new ColumnHeader();
            Score = new ColumnHeader();
            soundPictureBox = new PictureBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            Loading_label = new Label();
            pictureBox1 = new PictureBox();
            toolTip = new ToolTip(components);
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            isim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)oyunBilgisiIkon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // oyunBilgisiIkon
            // 
            oyunBilgisiIkon.BackColor = Color.Transparent;
            oyunBilgisiIkon.Image = (Image)resources.GetObject("oyunBilgisiIkon.Image");
            oyunBilgisiIkon.Location = new Point(86, 11);
            oyunBilgisiIkon.Name = "oyunBilgisiIkon";
            oyunBilgisiIkon.Size = new Size(50, 50);
            oyunBilgisiIkon.SizeMode = PictureBoxSizeMode.Zoom;
            oyunBilgisiIkon.TabIndex = 7;
            oyunBilgisiIkon.TabStop = false;
            oyunBilgisiIkon.Tag = "bakbakbakab";
            // 
            // xButton
            // 
            xButton.BackColor = Color.Transparent;
            xButton.Image = Properties.Resources.x_mark;
            xButton.Location = new Point(968, 16);
            xButton.Name = "xButton";
            xButton.Size = new Size(40, 40);
            xButton.SizeMode = PictureBoxSizeMode.Zoom;
            xButton.TabIndex = 6;
            xButton.TabStop = false;
            xButton.Click += xButton_Click;
            // 
            // oyunBilgiEtiket
            // 
            oyunBilgiEtiket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oyunBilgiEtiket.BackColor = Color.Transparent;
            oyunBilgiEtiket.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            oyunBilgiEtiket.ForeColor = Color.White;
            oyunBilgiEtiket.Location = new Point(70, 64);
            oyunBilgiEtiket.Name = "oyunBilgiEtiket";
            oyunBilgiEtiket.Size = new Size(88, 16);
            oyunBilgiEtiket.TabIndex = 8;
            oyunBilgiEtiket.Text = "Nasıl Oynanır? ";
            oyunBilgiEtiket.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(432, 376);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 9;
            label3.Text = "EN YÜKSEK 3 SKOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.Columns.AddRange(new ColumnHeader[] { Tier, nickName, Score });
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(380, 404);
            listView1.Name = "listView1";
            listView1.Size = new Size(264, 90);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Tier
            // 
            Tier.Text = "";
            Tier.Width = 30;
            // 
            // nickName
            // 
            nickName.Text = "Kullanıcı Adı";
            nickName.Width = 130;
            // 
            // Score
            // 
            Score.Text = "Skor";
            Score.Width = 100;
            // 
            // soundPictureBox
            // 
            soundPictureBox.BackColor = Color.Transparent;
            soundPictureBox.Image = Properties.Resources.sound_on;
            soundPictureBox.Location = new Point(968, 520);
            soundPictureBox.Name = "soundPictureBox";
            soundPictureBox.Size = new Size(40, 40);
            soundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            soundPictureBox.TabIndex = 11;
            soundPictureBox.TabStop = false;
            soundPictureBox.Click += pictureBox2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(379, 298);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(266, 28);
            progressBar1.TabIndex = 12;
            progressBar1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // Loading_label
            // 
            Loading_label.BackColor = Color.Transparent;
            Loading_label.ForeColor = Color.White;
            Loading_label.Location = new Point(459, 274);
            Loading_label.Name = "Loading_label";
            Loading_label.Size = new Size(106, 16);
            Loading_label.TabIndex = 13;
            Loading_label.Text = "Başlatılıyor...:  %0";
            Loading_label.TextAlign = ContentAlignment.MiddleCenter;
            Loading_label.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.settingmark;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(254, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(522, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 64);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 16;
            label4.Text = "Ayarlar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(isim);
            panel1.Location = new Point(332, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 128);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(142, 91);
            button1.Name = "button1";
            button1.Size = new Size(76, 25);
            button1.TabIndex = 2;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 16);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 3;
            label2.Text = "KULLANICI ADI";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // isim
            // 
            isim.Location = new Point(103, 52);
            isim.Name = "isim";
            isim.Size = new Size(154, 23);
            isim.TabIndex = 1;
            // 
            // girisSayfasiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 576);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(oyunBilgisiIkon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Loading_label);
            Controls.Add(progressBar1);
            Controls.Add(soundPictureBox);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(oyunBilgiEtiket);
            Controls.Add(xButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "girisSayfasiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += girisSayfasiForm_Load;
            ((System.ComponentModel.ISupportInitialize)oyunBilgisiIkon).EndInit();
            ((System.ComponentModel.ISupportInitialize)xButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)soundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox xButton;
        private PictureBox oyunBilgisiIkon;
        private Label oyunBilgiEtiket;
        private Label label3;
        private ListView listView1;
        private ColumnHeader nickName;
        private ColumnHeader Score;
        private ColumnHeader Tier;
        private PictureBox soundPictureBox;
        public Label Loading_label;
        public ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private ToolTip toolTip;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel panel1;
        private TextBox isim;
        private Label label2;
        private Button button1;
    }
}