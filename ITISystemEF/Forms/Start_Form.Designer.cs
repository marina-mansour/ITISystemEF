namespace ITISystemEF
{
    partial class Start_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            btnStart = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Gold;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.DarkRed;
            btnStart.Location = new Point(357, 322);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(163, 55);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkRed;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Tw Cen MT Condensed Extra Bold", 10.2F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(787, 446);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 472);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Start_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(877, 496);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Name = "Start_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITI Management System";
            Load += Start_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}
