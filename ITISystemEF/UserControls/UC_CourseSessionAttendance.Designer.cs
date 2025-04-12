namespace ITISystemEF.UserControls
{
    partial class UC_CourseSessionAttendance
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
            cboCourseSession = new ComboBox();
            cboStudent = new ComboBox();
            dgvCourseSessionAttendance = new DataGridView();
            dgCourseSessionAttendanceId = new DataGridViewTextBoxColumn();
            dgStudent = new DataGridViewTextBoxColumn();
            dgCourseSession = new DataGridViewTextBoxColumn();
            dgGrade = new DataGridViewTextBoxColumn();
            dgNotes = new DataGridViewTextBoxColumn();
            btnCancle = new Button();
            btnDelete = new Button();
            label5 = new Label();
            btnSave = new Button();
            label2 = new Label();
            txtNotes = new TextBox();
            label4 = new Label();
            txtGrade = new TextBox();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvCourseSessionAttendance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Course Session Attendance";
            // 
            // cboCourseSession
            // 
            cboCourseSession.FormattingEnabled = true;
            cboCourseSession.Location = new Point(157, 158);
            cboCourseSession.Name = "cboCourseSession";
            cboCourseSession.Size = new Size(217, 28);
            cboCourseSession.TabIndex = 48;
            cboCourseSession.SelectedIndexChanged += cboCourseSession_SelectedIndexChanged;
            // 
            // cboStudent
            // 
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(157, 124);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(217, 28);
            cboStudent.TabIndex = 49;
            cboStudent.SelectedIndexChanged += cboStudent_SelectedIndexChanged;
            // 
            // dgvCourseSessionAttendance
            // 
            dgvCourseSessionAttendance.AllowUserToDeleteRows = false;
            dgvCourseSessionAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseSessionAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCourseSessionAttendance.BackgroundColor = Color.White;
            dgvCourseSessionAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseSessionAttendance.Columns.AddRange(new DataGridViewColumn[] { dgCourseSessionAttendanceId, dgStudent, dgCourseSession, dgGrade, dgNotes });
            dgvCourseSessionAttendance.Location = new Point(426, 3);
            dgvCourseSessionAttendance.Name = "dgvCourseSessionAttendance";
            dgvCourseSessionAttendance.ReadOnly = true;
            dgvCourseSessionAttendance.RowHeadersWidth = 51;
            dgvCourseSessionAttendance.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvCourseSessionAttendance.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvCourseSessionAttendance.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvCourseSessionAttendance.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvCourseSessionAttendance.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvCourseSessionAttendance.RowTemplate.Height = 30;
            dgvCourseSessionAttendance.Size = new Size(448, 366);
            dgvCourseSessionAttendance.TabIndex = 47;
            dgvCourseSessionAttendance.DoubleClick += dgvCourseSessionAttendance_DoubleClick;
            // 
            // dgCourseSessionAttendanceId
            // 
            dgCourseSessionAttendanceId.DataPropertyName = "Id";
            dgCourseSessionAttendanceId.HeaderText = "Course Session Attendance ID";
            dgCourseSessionAttendanceId.MinimumWidth = 6;
            dgCourseSessionAttendanceId.Name = "dgCourseSessionAttendanceId";
            dgCourseSessionAttendanceId.ReadOnly = true;
            dgCourseSessionAttendanceId.Visible = false;
            // 
            // dgStudent
            // 
            dgStudent.DataPropertyName = "Student";
            dgStudent.HeaderText = "Student";
            dgStudent.MinimumWidth = 6;
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            // 
            // dgCourseSession
            // 
            dgCourseSession.DataPropertyName = "CourseSession";
            dgCourseSession.HeaderText = "Course Session";
            dgCourseSession.MinimumWidth = 6;
            dgCourseSession.Name = "dgCourseSession";
            dgCourseSession.ReadOnly = true;
            // 
            // dgGrade
            // 
            dgGrade.DataPropertyName = "Grade";
            dgGrade.HeaderText = "Grade";
            dgGrade.MinimumWidth = 6;
            dgGrade.Name = "dgGrade";
            dgGrade.ReadOnly = true;
            // 
            // dgNotes
            // 
            dgNotes.DataPropertyName = "Notes";
            dgNotes.HeaderText = "Notes";
            dgNotes.MinimumWidth = 6;
            dgNotes.Name = "dgNotes";
            dgNotes.ReadOnly = true;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.DarkRed;
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(280, 270);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(94, 29);
            btnCancle.TabIndex = 44;
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
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 166);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 38;
            label5.Text = "Course Session";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(80, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 132);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 39;
            label2.Text = "Student";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(157, 225);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(217, 27);
            txtNotes.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 232);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 40;
            label4.Text = "Notes";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(157, 192);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(217, 27);
            txtGrade.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 199);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 41;
            label3.Text = "Grade";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // UC_CourseSessionAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboCourseSession);
            Controls.Add(cboStudent);
            Controls.Add(dgvCourseSessionAttendance);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtNotes);
            Controls.Add(label4);
            Controls.Add(txtGrade);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_CourseSessionAttendance";
            Size = new Size(877, 372);
            Load += UC_CourseSessionAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourseSessionAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCourseSession;
        private ComboBox cboStudent;
        private DataGridView dgvCourseSessionAttendance;
        private Button btnCancle;
        private Button btnDelete;
        private Label label5;
        private Button btnSave;
        private Label label2;
        private TextBox txtNotes;
        private Label label4;
        private TextBox txtGrade;
        private Label label3;
        private DataGridViewTextBoxColumn dgCourseSessionAttendanceId;
        private DataGridViewTextBoxColumn dgStudent;
        private DataGridViewTextBoxColumn dgCourseSession;
        private DataGridViewTextBoxColumn dgGrade;
        private DataGridViewTextBoxColumn dgNotes;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
