namespace ITISystemEF.UserControls
{
    partial class UC_CourseSessions
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
            cboCourse = new ComboBox();
            dgvCourseSessions = new DataGridView();
            dgCourseSessionId = new DataGridViewTextBoxColumn();
            dgTitle = new DataGridViewTextBoxColumn();
            dgDate = new DataGridViewTextBoxColumn();
            dgCourse = new DataGridViewTextBoxColumn();
            dgInstructor = new DataGridViewTextBoxColumn();
            btnCancle = new Button();
            btnDelete = new Button();
            label5 = new Label();
            btnSave = new Button();
            label2 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCourseSessions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Course Session";
            // 
            // cboInstructor
            // 
            cboInstructor.FormattingEnabled = true;
            cboInstructor.Location = new Point(156, 222);
            cboInstructor.Name = "cboInstructor";
            cboInstructor.Size = new Size(217, 28);
            cboInstructor.TabIndex = 48;
            cboInstructor.SelectedIndexChanged += cboInstructor_SelectedIndexChanged;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(156, 188);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(217, 28);
            cboCourse.TabIndex = 49;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // dgvCourseSessions
            // 
            dgvCourseSessions.AllowUserToDeleteRows = false;
            dgvCourseSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseSessions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCourseSessions.BackgroundColor = Color.White;
            dgvCourseSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseSessions.Columns.AddRange(new DataGridViewColumn[] { dgCourseSessionId, dgTitle, dgDate, dgCourse, dgInstructor });
            dgvCourseSessions.Location = new Point(426, 3);
            dgvCourseSessions.Name = "dgvCourseSessions";
            dgvCourseSessions.ReadOnly = true;
            dgvCourseSessions.RowHeadersWidth = 51;
            dgvCourseSessions.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvCourseSessions.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvCourseSessions.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvCourseSessions.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvCourseSessions.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvCourseSessions.RowTemplate.Height = 30;
            dgvCourseSessions.Size = new Size(448, 366);
            dgvCourseSessions.TabIndex = 47;
            dgvCourseSessions.DoubleClick += dgvCourseSessions_DoubleClick;
            // 
            // dgCourseSessionId
            // 
            dgCourseSessionId.DataPropertyName = "Id";
            dgCourseSessionId.HeaderText = "CourseSession ID";
            dgCourseSessionId.MinimumWidth = 6;
            dgCourseSessionId.Name = "dgCourseSessionId";
            dgCourseSessionId.ReadOnly = true;
            dgCourseSessionId.Visible = false;
            // 
            // dgTitle
            // 
            dgTitle.DataPropertyName = "Title";
            dgTitle.HeaderText = "Title";
            dgTitle.MinimumWidth = 6;
            dgTitle.Name = "dgTitle";
            dgTitle.ReadOnly = true;
            // 
            // dgDate
            // 
            dgDate.DataPropertyName = "Date";
            dgDate.HeaderText = "Date";
            dgDate.MinimumWidth = 6;
            dgDate.Name = "dgDate";
            dgDate.ReadOnly = true;
            // 
            // dgCourse
            // 
            dgCourse.DataPropertyName = "Course";
            dgCourse.HeaderText = "Course";
            dgCourse.MinimumWidth = 6;
            dgCourse.Name = "dgCourse";
            dgCourse.ReadOnly = true;
            // 
            // dgInstructor
            // 
            dgInstructor.DataPropertyName = "Instructor";
            dgInstructor.HeaderText = "Instructor";
            dgInstructor.MinimumWidth = 6;
            dgInstructor.Name = "dgInstructor";
            dgInstructor.ReadOnly = true;
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
            label5.Location = new Point(48, 230);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 38;
            label5.Text = "Instructor";
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
            label2.Location = new Point(65, 196);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 39;
            label2.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 162);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 40;
            label4.Text = "Date";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(156, 122);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(217, 27);
            txtTitle.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 129);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 41;
            label3.Text = "Title";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(157, 155);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(216, 27);
            dtpDate.TabIndex = 50;
            // 
            // UC_CourseSessions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpDate);
            Controls.Add(cboInstructor);
            Controls.Add(cboCourse);
            Controls.Add(dgvCourseSessions);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_CourseSessions";
            Size = new Size(877, 372);
            Load += UC_CourseSessions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourseSessions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboInstructor;
        private ComboBox cboCourse;
        private DataGridView dgvCourseSessions;
        private Button btnCancle;
        private Button btnDelete;
        private Label label5;
        private Button btnSave;
        private Label label2;
        private Label label4;
        private TextBox txtTitle;
        private Label label3;
        private DataGridViewTextBoxColumn dgCourseSessionId;
        private DataGridViewTextBoxColumn dgTitle;
        private DataGridViewTextBoxColumn dgDate;
        private DataGridViewTextBoxColumn dgCourse;
        private DataGridViewTextBoxColumn dgInstructor;
        private DateTimePicker dtpDate;
    }
}
