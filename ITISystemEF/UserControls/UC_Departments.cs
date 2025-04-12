using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITISystemEF.Context;
using ITISystemEF.Models;
using ITISystemEF.ViewModels;

namespace ITISystemEF.UserControls
{
    public partial class UC_Departments : UserControl
    {
        Department department = new Department();
        private int? selectedManager = null;
        public UC_Departments()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtName.Text = txtLocation.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            department.DepartmentId = 0;
            cboManager.SelectedIndex = 0;
        }
        void loadDepartments()
        {
            dgvDepartments.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var departments = db.Departments
                    .Select(d => new
                    {
                        d.DepartmentId,
                        d.Name,
                        d.Location,
                        Manager = d.Manager.FName + " " + d.Manager.LName
                    })
                    .ToList();
                dgvDepartments.DataSource = departments;
            }
        }
        private void UC_Departments_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtName;
            using (MyContext db = new MyContext())
            {
                var instructors = db.Instructors
                    .Select(i => new ComboManager { Id = i.InstructorId, Name = $"{i.FName} {i.LName}" })
                    .ToList();
                instructors.Insert(0, new ComboManager { Id = null, Name = "-- Select Manager --" });
                cboManager.DataSource = instructors;
                cboManager.DisplayMember = "Name";
                cboManager.ValueMember = "Id";
                cboManager.SelectedIndex = 0;
            }
            clear();
            loadDepartments();
        }
        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void cboManager_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboManager.SelectedIndex > 0 && cboManager.SelectedValue != null && int.TryParse(cboManager.SelectedValue.ToString(), out int managerId))
            {
                selectedManager = managerId;
            }
            else
            {
                selectedManager = null;
            }
        }
        private void dgvDepartments_DoubleClick(object sender, EventArgs e)
        {

            if (dgvDepartments.CurrentRow != null)
            {
                department.DepartmentId = Convert.ToInt32(dgvDepartments.CurrentRow.Cells["dgDepartmentId"].Value);


                txtName.Text = dgvDepartments.CurrentRow.Cells["dgName"].Value.ToString();
                txtLocation.Text = dgvDepartments.CurrentRow.Cells["dgLocation"].Value.ToString();

                string managerName = dgvDepartments.CurrentRow.Cells["dgManager"].Value?.ToString();

                if (!string.IsNullOrEmpty(managerName))
                {
                    var managers = (List<ComboManager>)cboManager.DataSource;
                    var manager = managers
                        .FirstOrDefault(m => m.Name == managerName);

                    if (manager != null)
                    {
                        cboManager.SelectedValue = manager.Id;
                    }
                }
                else
                {
                    cboManager.SelectedIndex = 0;
                }

                //if (dgvDepartments.CurrentRow.Cells["dgManager"].Value != null)
                //    cboManager.SelectedValue = dgvDepartments.CurrentRow.Cells["dgManager"].Value;
                //else
                //    cboManager.SelectedIndex = 0;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            department.Name = txtName.Text;
            department.Location = txtLocation.Text;
            if (selectedManager != null)
                department.ManagerId = Convert.ToInt32(cboManager.SelectedValue);
            else
                department.ManagerId = null;


            using (MyContext db = new MyContext())
            {
                if (department.ManagerId != null)
                {

                    if (department.DepartmentId != null)
                    {
                        bool isDuplicateManager = db.Departments
                            .Any(d => d.ManagerId == department.ManagerId && d.DepartmentId != department.DepartmentId);

                        if (isDuplicateManager)
                        {
                            MessageBox.Show("This manager is already assigned to another department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (btnSave.Text == "Save" && department.DepartmentId == 0)
                {
                    db.Departments.Add(department);
                    db.SaveChanges();
                    //loadDepartments();
                    MessageBox.Show("Department Added Successfully");
                }
                else
                {
                    db.Departments.Update(department);
                    db.SaveChanges();
                    //loadDepartments();
                    MessageBox.Show("Department Updated Successfully");
                }
            }

            clear();
            loadDepartments();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Department?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    department.DepartmentId = Convert.ToInt32(dgvDepartments.CurrentRow.Cells["dgDepartmentId"].Value);

                    var dept = db.Departments.Find(department.DepartmentId);
                    if (dept != null)
                    {
                        db.Departments.Remove(dept);
                        db.SaveChanges();
                        loadDepartments();
                        clear();
                        MessageBox.Show("Department Deleted Successfully");
                    }
                }
            }

        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
