namespace yaho2
{
    partial class zorluksecim
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "OYUN ZORLUĞU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(96, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(10, 0, 0, 0);
            radioButton1.Size = new Size(64, 32);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kolay";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(96, 112);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(10, 0, 0, 0);
            radioButton2.Size = new Size(64, 32);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Orta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton3.Location = new Point(96, 152);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(10, 0, 0, 0);
            radioButton3.Size = new Size(64, 32);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Zor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(80, 208);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 4;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // zorluksecim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(256, 256);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "zorluksecim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zorluksecim";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
    }
}