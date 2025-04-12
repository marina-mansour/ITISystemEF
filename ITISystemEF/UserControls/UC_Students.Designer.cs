namespace ITISystemEF.UserControls
{
    partial class UC_Students
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSave = new Button();
            dgvStudents = new DataGridView();
            btnDelete = new Button();
            btnCancle = new Button();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            dgStudentID = new DataGridViewTextBoxColumn();
            dgFirstName = new DataGridViewTextBoxColumn();
            dgLastName = new DataGridViewTextBoxColumn();
            dgPhone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Student";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(80, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { dgStudentID, dgFirstName, dgLastName, dgPhone });
            dgvStudents.Location = new Point(426, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvStudents.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvStudents.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvStudents.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvStudents.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvStudents.RowTemplate.Height = 30;
            dgvStudents.Size = new Size(448, 366);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            dgvStudents.DoubleClick += dgvStudents_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(180, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_CLick;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.DarkRed;
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(280, 270);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(94, 29);
            btnCancle.TabIndex = 3;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 1;
            label3.Text = "First Name";
            label3.Click += label3_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(155, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 27);
            txtFirstName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 162);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 27);
            txtLastName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 195);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(156, 188);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(217, 27);
            txtPhone.TabIndex = 2;
            // 
            // dgStudentID
            // 
            dgStudentID.DataPropertyName = "Id";
            dgStudentID.HeaderText = "Student ID";
            dgStudentID.MinimumWidth = 6;
            dgStudentID.Name = "dgStudentID";
            dgStudentID.ReadOnly = true;
            dgStudentID.Visible = false;
            dgStudentID.Width = 125;
            // 
            // dgFirstName
            // 
            dgFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgFirstName.DataPropertyName = "FName";
            dgFirstName.HeaderText = "First Name";
            dgFirstName.MinimumWidth = 6;
            dgFirstName.Name = "dgFirstName";
            dgFirstName.ReadOnly = true;
            // 
            // dgLastName
            // 
            dgLastName.DataPropertyName = "LName";
            dgLastName.HeaderText = "Last Name";
            dgLastName.MinimumWidth = 6;
            dgLastName.Name = "dgLastName";
            dgLastName.ReadOnly = true;
            dgLastName.Width = 125;
            // 
            // dgPhone
            // 
            dgPhone.DataPropertyName = "Phone";
            dgPhone.HeaderText = "Phone";
            dgPhone.MinimumWidth = 6;
            dgPhone.Name = "dgPhone";
            dgPhone.ReadOnly = true;
            dgPhone.Width = 125;
            // 
            // UC_Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_Students";
            Size = new Size(877, 372);
            Load += UC_Students_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private DataGridView dgvStudents;
        private Button btnDelete;
        private Button btnCancle;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private TextBox txtPhone;
        private DataGridViewTextBoxColumn dgStudentID;
        private DataGridViewTextBoxColumn dgFirstName;
        private DataGridViewTextBoxColumn dgLastName;
        private DataGridViewTextBoxColumn dgPhone;
    }
}
