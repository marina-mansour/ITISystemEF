namespace ITISystemEF.UserControls
{
    partial class UC_Departments
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
            cboManager = new ComboBox();
            dgvDepartments = new DataGridView();
            btnCancle = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtLocation = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            dgDepartmentId = new DataGridViewTextBoxColumn();
            dgName = new DataGridViewTextBoxColumn();
            dgLocation = new DataGridViewTextBoxColumn();
            dgManager = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Departments";
            //label1.Click += label1_Click;
            // 
            // cboManager
            // 
            cboManager.FormattingEnabled = true;
            cboManager.Location = new Point(156, 188);
            cboManager.Name = "cboManager";
            cboManager.Size = new Size(217, 28);
            cboManager.TabIndex = 27;
            cboManager.SelectedIndexChanged += cboManager_SelectedIndexChanged;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToDeleteRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDepartments.BackgroundColor = Color.White;
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Columns.AddRange(new DataGridViewColumn[] { dgDepartmentId, dgName, dgLocation, dgManager });
            dgvDepartments.Location = new Point(426, 3);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvDepartments.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
            dgvDepartments.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvDepartments.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dgvDepartments.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
            dgvDepartments.RowTemplate.Height = 30;
            dgvDepartments.Size = new Size(448, 366);
            dgvDepartments.TabIndex = 26;
            dgvDepartments.CellContentClick += dgvDepartments_CellContentClick;
            dgvDepartments.DoubleClick += dgvDepartments_DoubleClick;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.DarkRed;
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(280, 270);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(94, 29);
            btnCancle.TabIndex = 23;
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
            btnDelete.TabIndex = 24;
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
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 196);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 16;
            label2.Text = "Manager";
            //label2.Click += label2_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(156, 155);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(217, 27);
            txtLocation.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 162);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 18;
            label4.Text = "Location";
            //label4.Click += label4_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Name";
            // 
            // dgDepartmentId
            // 
            dgDepartmentId.DataPropertyName = "DepartmentId";
            dgDepartmentId.HeaderText = "Department ID";
            dgDepartmentId.MinimumWidth = 6;
            dgDepartmentId.Name = "dgDepartmentId";
            dgDepartmentId.ReadOnly = true;
            dgDepartmentId.Visible = false;
            // 
            // dgName
            // 
            dgName.DataPropertyName = "Name";
            dgName.HeaderText = "Name";
            dgName.MinimumWidth = 6;
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            // 
            // dgLocation
            // 
            dgLocation.DataPropertyName = "Location";
            dgLocation.HeaderText = "Location";
            dgLocation.MinimumWidth = 6;
            dgLocation.Name = "dgLocation";
            dgLocation.ReadOnly = true;
            // 
            // dgManager
            // 
            dgManager.DataPropertyName = "Manager";
            dgManager.HeaderText = "Manager";
            dgManager.MinimumWidth = 6;
            dgManager.Name = "dgManager";
            dgManager.ReadOnly = true;
            // 
            // UC_Departments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboManager);
            Controls.Add(dgvDepartments);
            Controls.Add(btnCancle);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtLocation);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_Departments";
            Size = new Size(877, 372);
            Load += UC_Departments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboManager;
        private DataGridView dgvDepartments;
        private Button btnCancle;
        private Button btnDelete;
        private Button btnSave;
        private Label label2;
        private TextBox txtLocation;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private DataGridViewTextBoxColumn dgDepartmentId;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgLocation;
        private DataGridViewTextBoxColumn dgManager;
    }
}
