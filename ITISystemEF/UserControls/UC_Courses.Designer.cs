namespace ITISystemEF.UserControls
{
    partial class UC_Courses
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
            cboInstructor = new ComboBox();
            dgvCourses = new DataGridView();
            dgCourseId = new DataGridViewTextBoxColumn();
            dgName = new DataGridViewTextBoxColumn();
            dgDuration = new DataGridViewTextBoxColumn();
            dgInstructor = new DataGridViewTextBoxColumn();
            dgDepartment = new DataGridViewTextBoxColumn();
            btnCancle = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtDuration = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label5 = new Label();
            cboDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Courses";
            // 
            // cboInstructor
            // 
            cboInstructor.FormattingEnabled = true;
            cboInstructor.Location = new Point(156, 188);
            cboInstructor.Name = "cboInstructor";
            cboInstructor.Size = new Size(217, 28);
            cboInstructor.TabIndex = 37;
            cboInstructor.SelectedIndexChanged += cboInstructor_SelectedIndexChanged;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Columns.AddRange(new DataGridViewColumn[] { dgCourseId, dgName, dgDuration, dgInstructor, dgDepartment });
            dgvCourses.Location = new Point(426, 3);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvCourses.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvCourses.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvCourses.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvCourses.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvCourses.RowTemplate.Height = 30;
            dgvCourses.Size = new Size(448, 366);
            dgvCourses.TabIndex = 36;
            dgvCourses.DoubleClick += dgvCourses_DoubleClick;
            // 
            // dgCourseId
            // 
            dgCourseId.DataPropertyName = "Id";
            dgCourseId.HeaderText = "Course ID";
            dgCourseId.MinimumWidth = 6;
            dgCourseId.Name = "dgCourseId";
            dgCourseId.ReadOnly = true;
            dgCourseId.Visible = false;
            // 
            // dgName
            // 
            dgName.DataPropertyName = "Name";
            dgName.HeaderText = "Name";
            dgName.MinimumWidth = 6;
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            // 
            // dgDuration
            // 
            dgDuration.DataPropertyName = "Duration";
            dgDuration.HeaderText = "Duration";
            dgDuration.MinimumWidth = 6;
            dgDuration.Name = "dgDuration";
            dgDuration.ReadOnly = true;
            // 
            // dgInstructor
            // 
            dgInstructor.DataPropertyName = "Instructor";
            dgInstructor.HeaderText = "Instructor";
            dgInstructor.MinimumWidth = 6;
            dgInstructor.Name = "dgInstructor";
            dgInstructor.ReadOnly = true;
            // 
            // dgDepartment
            // 
            dgDepartment.DataPropertyName = "Department";
            dgDepartment.HeaderText = "Department";
            dgDepartment.MinimumWidth = 6;
            dgDepartment.Name = "dgDepartment";
            dgDepartment.ReadOnly = true;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.DarkRed;
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(280, 270);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(94, 29);
            btnCancle.TabIndex = 33;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(180, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(80, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 196);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 28;
            label2.Text = "Instructor";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(156, 155);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(217, 27);
            txtDuration.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 162);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 29;
            label4.Text = "Duration";
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 30;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 230);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 28;
            label5.Text = "Department";
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(156, 222);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(217, 28);
            cboDepartment.TabIndex = 37;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // UC_Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboDepartment);
            Controls.Add(cboInstructor);
            Controls.Add(dgvCourses);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtDuration);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_Courses";
            Size = new Size(877, 372);
            Load += UC_Courses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboInstructor;
        private DataGridView dgvCourses;
        private Button btnCancle;
        private Button btnDelete;
        private Button btnSave;
        private Label label2;
        private TextBox txtDuration;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Label label5;
        private ComboBox cboDepartment;
        private DataGridViewTextBoxColumn dgCourseId;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgDuration;
        private DataGridViewTextBoxColumn dgInstructor;
        private DataGridViewTextBoxColumn dgDepartment;
    }
}
