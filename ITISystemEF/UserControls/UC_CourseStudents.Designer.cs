namespace ITISystemEF.UserControls
{
    partial class UC_CourseStudents
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
            cboCourse = new ComboBox();
            cboStudent = new ComboBox();
            dgvCourseStudent = new DataGridView();
            btnCancle = new Button();
            btnDelete = new Button();
            label5 = new Label();
            btnSave = new Button();
            label2 = new Label();
            dgStudentId = new DataGridViewTextBoxColumn();
            dgCourseId = new DataGridViewTextBoxColumn();
            dgStudent = new DataGridViewTextBoxColumn();
            dgCourse = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCourseStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Course Students";
            //label1.Click += label1_Click;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(157, 179);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(217, 28);
            cboCourse.TabIndex = 60;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // cboStudent
            // 
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(157, 145);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(217, 28);
            cboStudent.TabIndex = 61;
            cboStudent.SelectedIndexChanged += cboStudent_SelectedIndexChanged;
            // 
            // dgvCourseStudent
            // 
            dgvCourseStudent.AllowUserToDeleteRows = false;
            dgvCourseStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCourseStudent.BackgroundColor = Color.White;
            dgvCourseStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseStudent.Columns.AddRange(new DataGridViewColumn[] { dgStudentId, dgCourseId, dgStudent, dgCourse });
            dgvCourseStudent.Location = new Point(426, 2);
            dgvCourseStudent.Name = "dgvCourseStudent";
            dgvCourseStudent.ReadOnly = true;
            dgvCourseStudent.RowHeadersWidth = 51;
            dgvCourseStudent.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvCourseStudent.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvCourseStudent.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvCourseStudent.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvCourseStudent.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvCourseStudent.RowTemplate.Height = 30;
            dgvCourseStudent.Size = new Size(448, 366);
            dgvCourseStudent.TabIndex = 59;
            dgvCourseStudent.DoubleClick += dgvCourseStudent_DoubleClick;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.DarkRed;
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(280, 269);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(94, 29);
            btnCancle.TabIndex = 56;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(180, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 50;
            label5.Text = "Course";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(80, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 58;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 153);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 51;
            label2.Text = "Student";
            // 
            // dgStudentId
            // 
            dgStudentId.DataPropertyName = "StudentId";
            dgStudentId.HeaderText = "Student Id";
            dgStudentId.MinimumWidth = 6;
            dgStudentId.Name = "dgStudentId";
            dgStudentId.ReadOnly = true;
            dgStudentId.Visible = false;
            // 
            // dgCourseId
            // 
            dgCourseId.DataPropertyName = "CourseId";
            dgCourseId.HeaderText = "Course Id";
            dgCourseId.MinimumWidth = 6;
            dgCourseId.Name = "dgCourseId";
            dgCourseId.ReadOnly = true;
            dgCourseId.Visible = false;
            // 
            // dgStudent
            // 
            dgStudent.DataPropertyName = "Student";
            dgStudent.HeaderText = "Student";
            dgStudent.MinimumWidth = 6;
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            // 
            // dgCourse
            // 
            dgCourse.DataPropertyName = "Course";
            dgCourse.HeaderText = "Course";
            dgCourse.MinimumWidth = 6;
            dgCourse.Name = "dgCourse";
            dgCourse.ReadOnly = true;
            // 
            // UC_CourseStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboCourse);
            Controls.Add(cboStudent);
            Controls.Add(dgvCourseStudent);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_CourseStudents";
            Size = new Size(877, 372);
            Load += UC_CourseStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourseStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCourse;
        private ComboBox cboStudent;
        private DataGridView dgvCourseStudent;
        private Button btnCancle;
        private Button btnDelete;
        private Label label5;
        private Button btnSave;
        private Label label2;
        private DataGridViewTextBoxColumn dgStudentId;
        private DataGridViewTextBoxColumn dgCourseId;
        private DataGridViewTextBoxColumn dgStudent;
        private DataGridViewTextBoxColumn dgCourse;
    }
}
