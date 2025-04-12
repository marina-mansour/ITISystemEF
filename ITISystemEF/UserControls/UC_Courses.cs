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
    public partial class UC_Courses : UserControl
    {
        Course course = new Course();
        private int selectedInstrucor = 0;
        private int selectedDepartment = 0;
        public UC_Courses()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtName.Text = txtDuration.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            course.Id = 0;
            cboInstructor.SelectedIndex = 0;
            cboDepartment.SelectedIndex = 0;
        }
        void loadCourses()
        {
            dgvCourses.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var courses = db.Courses
                    .Select(c => new
                    {
                        c.Id,
                        c.Name,
                        c.Duration,
                        Instructor = c.Instructor.FName + " " + c.Instructor.LName,
                        Department = c.Department.Name
                    })
                    .ToList();
                dgvCourses.DataSource = courses;
            }
        }
        private void UC_Courses_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;

            using (MyContext db = new MyContext())
            {
                var instructors = db.Instructors
                    .Select(i => new ComboInstructor
                    {
                        Id = i.InstructorId,
                        Name = i.FName + " " + i.LName
                    })
                    .ToList();
                var departments = db.Departments
                    .Select(d => new ComboDepartment
                    {
                        Id = d.DepartmentId,
                        Name = d.Name
                    })
                    .ToList();
                instructors.Insert(0, new ComboInstructor { Id = null, Name = "-- Select Instructor --" });
                departments.Insert(0, new ComboDepartment { Id = null, Name = "-- Select Department --" });

                cboInstructor.DataSource = instructors;
                cboInstructor.DisplayMember = "Name";
                cboInstructor.ValueMember = "Id";

                cboDepartment.DataSource = departments;
                cboDepartment.DisplayMember = "Name";
                cboDepartment.ValueMember = "Id";

                cboInstructor.SelectedIndex = 0;
                cboDepartment.SelectedIndex = 0;
            }
            clear();
            loadCourses();
        }
        private void dgvCourses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                course.Id = Convert.ToInt32(dgvCourses.CurrentRow.Cells["dgCourseId"].Value);
                using (MyContext db = new MyContext())
                {
                    course = db.Courses.Find(course.Id);
                    if (course != null)
                    {
                        txtName.Text = course.Name;
                        txtDuration.Text = course.Duration.ToString();
                        cboInstructor.SelectedValue = course.InstructorId;
                        cboDepartment.SelectedValue = course.DepartmentId;
                        btnSave.Text = "Update";
                        btnDelete.Enabled = true;
                    }
                }
            }
        }
        private void cboInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInstructor.SelectedValue != null && cboInstructor.SelectedIndex > 0 && int.TryParse(cboInstructor.SelectedValue.ToString(), out int InstructorId))
                selectedInstrucor = InstructorId;
            else
                selectedInstrucor = 0;
        }
        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedValue != null && cboDepartment.SelectedIndex > 0 && int.TryParse(cboDepartment.SelectedValue.ToString(), out int DepartmentId))
                selectedDepartment = DepartmentId;
            else
                selectedDepartment = 0;
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDuration.Text) || selectedDepartment == 0 || selectedInstrucor == 0)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            course.Name = txtName.Text;
            course.Duration = Convert.ToInt32(txtDuration.Text);
            course.InstructorId = selectedInstrucor;
            course.DepartmentId = selectedDepartment;


            using (MyContext db = new MyContext())
            {
                if (btnSave.Text == "Save" && course.Id == 0)
                {
                    db.Courses.Add(course);
                    db.SaveChanges();
                    MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.Courses.Update(course);
                    db.SaveChanges();
                    MessageBox.Show("Course updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            clear();
            loadCourses();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    db.Courses.Remove(course);
                    db.SaveChanges();
                    MessageBox.Show("Course deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clear();
                loadCourses();
            }
        }
    }
}
