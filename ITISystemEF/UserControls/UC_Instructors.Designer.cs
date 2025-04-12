
namespace ITISystemEF.UserControls
{
    partial class UC_Instructors
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvInstructors = new DataGridView();
            dgInstructorId = new DataGridViewTextBoxColumn();
            dgFisrtName = new DataGridViewTextBoxColumn();
            dgLastName = new DataGridViewTextBoxColumn();
            dgPhone = new DataGridViewTextBoxColumn();
            dgDepartment = new DataGridViewTextBoxColumn();
            btnCancle = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtPhone = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cboDepartment = new ComboBox();
            departmentBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Instructors";
            label1.Click += label1_Click;
            // 
            // dgvInstructors
            // 
            dgvInstructors.AllowUserToDeleteRows = false;
            dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInstructors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInstructors.BackgroundColor = Color.White;
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Columns.AddRange(new DataGridViewColumn[] { dgInstructorId, dgFisrtName, dgLastName, dgPhone, dgDepartment });
            dgvInstructors.Location = new Point(426, 3);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvInstructors.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvInstructors.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvInstructors.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvInstructors.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvInstructors.RowTemplate.Height = 30;
            dgvInstructors.Size = new Size(448, 366);
            dgvInstructors.TabIndex = 14;
            dgvInstructors.CellContentClick += dgvInstructors_CellContentClick;
            dgvInstructors.DoubleClick += dvgInstructors_DoubleClick;
            // 
            // dgInstructorId
            // 
            dgInstructorId.DataPropertyName = "InstructorId";
            dgInstructorId.HeaderText = "Instructor ID";
            dgInstructorId.MinimumWidth = 6;
            dgInstructorId.Name = "dgInstructorId";
            dgInstructorId.ReadOnly = true;
            dgInstructorId.Visible = false;
            // 
            // dgFisrtName
            // 
            dgFisrtName.DataPropertyName = "FName";
            dgFisrtName.HeaderText = "First Name";
            dgFisrtName.MinimumWidth = 6;
            dgFisrtName.Name = "dgFisrtName";
            dgFisrtName.ReadOnly = true;
            // 
            // dgLastName
            // 
            dgLastName.DataPropertyName = "LName";
            dgLastName.HeaderText = "Last Name";
            dgLastName.MinimumWidth = 6;
            dgLastName.Name = "dgLastName";
            dgLastName.ReadOnly = true;
            // 
            // dgPhone
            // 
            dgPhone.DataPropertyName = "Phone";
            dgPhone.HeaderText = "Phone";
            dgPhone.MinimumWidth = 6;
            dgPhone.Name = "dgPhone";
            dgPhone.ReadOnly = true;
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
            btnCancle.TabIndex = 11;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(180, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
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
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(156, 188);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(217, 27);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 195);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 27);
            txtLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 162);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 27);
            txtFirstName.TabIndex = 10;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 228);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Department";
            label2.Click += label2_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(156, 220);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(217, 28);
            cboDepartment.TabIndex = 15;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(Models.Department);
            // 
            // UC_Instructors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboDepartment);
            Controls.Add(dgvInstructors);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_Instructors";
            Size = new Size(877, 372);
            Load += UC_Instructors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private DataGridView dgvInstructors;
        private Button btnCancle;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cboDepartment;
        private BindingSource departmentBindingSource;
        private DataGridViewTextBoxColumn dgInstructorId;
        private DataGridViewTextBoxColumn dgFisrtName;
        private DataGridViewTextBoxColumn dgLastName;
        private DataGridViewTextBoxColumn dgPhone;
        private DataGridViewTextBoxColumn dgDepartment;
    }
}
