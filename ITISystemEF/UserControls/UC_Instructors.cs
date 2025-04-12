using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ITISystemEF.Context;
using ITISystemEF.Models;
using ITISystemEF.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ITISystemEF.UserControls
{
    public partial class UC_Instructors : UserControl
    {
        Instructor instructor = new Instructor();
        private int? selectedDepartment = null;
        public UC_Instructors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void dgvInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        void clear()
        {
            txtFirstName.Text = txtLastName.Text = txtPhone.Text = string.Empty;
            //if(cboDepartment.Items.Count > 0)
            cboDepartment.SelectedIndex = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            instructor.InstructorId = 0;
        }

        void loadInstructors()
        {
            dgvInstructors.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var instructors = db.Instructors
                    .Select(i => new
                    {
                        i.InstructorId,
                        i.FName,
                        i.LName,
                        i.Phone,
                        Department = i.Department != null ? i.Department.Name : "N/A"
                    })
                    .ToList();
                dgvInstructors.DataSource = instructors;
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UC_Instructors_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFirstName;

            using (MyContext db = new MyContext())
            {
                var departments = db.Departments
                    .Select(d => new ComboDepartment { Id = d.DepartmentId, Name = d.Name })
                    .ToList();

                departments.Insert(0, new ComboDepartment { Id = null, Name = "-- Select Department --" });
                cboDepartment.DataSource = departments;
                cboDepartment.DisplayMember = "Name";
                cboDepartment.ValueMember = "Id";
                cboDepartment.SelectedIndex = 0;
            }
            clear();
            loadInstructors();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex > 0 && cboDepartment.SelectedValue != null && int.TryParse(cboDepartment.SelectedValue.ToString(), out int deptId))
            {
                selectedDepartment = deptId;
            }
            else
            {
                selectedDepartment = null;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            instructor.FName = txtFirstName.Text.Trim();
            instructor.LName = txtLastName.Text;
            instructor.Phone = txtPhone.Text;
            if (selectedDepartment != null)
                instructor.DepartmentId = Convert.ToInt32(cboDepartment.SelectedValue);
            else
                instructor.DepartmentId = null;
            using (MyContext db = new MyContext())
            {

                if (btnSave.Text == "Save" && instructor.InstructorId == 0)
                {

                    db.Instructors.Add(instructor);
                    MessageBox.Show("Instructor Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    db.Instructors.Update(instructor);
                    MessageBox.Show("Instructor Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                db.SaveChanges();
            }
            clear();
            loadInstructors();
        }

        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void dvgInstructors_DoubleClick(object sender, EventArgs e)
        {

            if (dgvInstructors.CurrentRow != null)
            {
                instructor.InstructorId = Convert.ToInt32(dgvInstructors.CurrentRow.Cells["dgInstructorId"].Value);

                txtFirstName.Text = dgvInstructors.CurrentRow.Cells["dgFisrtName"].Value.ToString();
                txtLastName.Text = dgvInstructors.CurrentRow.Cells["dgLastName"].Value.ToString();
                txtPhone.Text = dgvInstructors.CurrentRow.Cells["dgPhone"].Value.ToString();

                string departmentName = dgvInstructors.CurrentRow.Cells["dgDepartment"].Value?.ToString();

                if (!string.IsNullOrEmpty(departmentName))
                {
                    var departments = (List<ComboDepartment>)cboDepartment.DataSource;
                    var selectedDepartment = departments.FirstOrDefault(d => d.Name == departmentName);
                    if (selectedDepartment != null)
                        cboDepartment.SelectedValue = selectedDepartment.Id;
                    else
                        cboDepartment.SelectedIndex = 0;
                }
            }

            ///////////////////////////////////////////////////
            //using(MyContext db = new MyContext())
            //{
            //    instructor = db.Instructors.Find(instructor.InstructorId);
            //    txtFirstName.Text = instructor.FName;
            //    txtLastName.Text = instructor.LName;
            //    txtPhone.Text = instructor.Phone;
            //    if (instructor.DepartmentId != null)
            //        cboDepartment.SelectedValue = instructor.DepartmentId;
            //    else
            //        cboDepartment.SelectedIndex = 0;
            //}
            ///////////////////////////////////////////////////
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this instructor?", "Delete Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {

                    bool isManager = db.Departments.Any(d => d.ManagerId == instructor.InstructorId);

                    if (isManager)
                    {
                        MessageBox.Show("Cannot delete this instructor because they are assigned as a department manager.",
                                        "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    instructor.InstructorId = Convert.ToInt32(dgvInstructors.CurrentRow.Cells["dgInstructorId"].Value);
                    var ins = db.Instructors.Find(instructor.InstructorId);
                    if (ins != null)
                    {
                        db.Instructors.Remove(ins);
                        db.SaveChanges();
                        loadInstructors();
                        clear();
                        MessageBox.Show("Instructor Deleted Successfully");
                    }
                }
            }
        }
    }
}
