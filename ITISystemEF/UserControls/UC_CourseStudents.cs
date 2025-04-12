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

namespace ITISystemEF.UserControls
{
    public partial class UC_CourseStudents : UserControl
    {

        CourseStudent courseStudent = new CourseStudent();
        private int selectedStudent = 0;
        private int selectedCourse = 0;
        public UC_CourseStudents()
        {
            InitializeComponent();
        }
        void clear()
        {
            cboCourse.SelectedIndex = 0;
            cboStudent.SelectedIndex = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            courseStudent.StudentId = 0;
            courseStudent.CourseId = 0;
        }
        void loadCourseStudents()
        {
            dgvCourseStudent.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var courseStudents = db.CourseStudents
                    .Select(cs => new
                    {
                        cs.StudentId,
                        cs.CourseId,
                        Student = cs.Student.FName + " " + cs.Student.LName,
                        Course = cs.Course.Name
                    })
                    .ToList();
                dgvCourseStudent.DataSource = courseStudents;
            }
        }
        

        private void UC_CourseStudents_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cboStudent;
            using (MyContext db = new MyContext())
            {
                var students = db.Students
                    .Select(s => new { s.Id, FullName = s.FName + " " + s.LName })
                    .ToList();
                students.Insert(0, new { Id = 0, FullName = "-- Select Student --" });
                cboStudent.DataSource = students;
                cboStudent.DisplayMember = "FullName";
                cboStudent.ValueMember = "Id";
                cboStudent.SelectedIndex = 0;


                var courses = db.Courses
                    .Select(c => new { c.Id, c.Name })
                    .ToList();
                courses.Insert(0, new { Id = 0, Name = "-- Select Course --" });
                cboCourse.DataSource = courses;
                cboCourse.DisplayMember = "Name";
                cboCourse.ValueMember = "Id";
                cboCourse.SelectedIndex = 0;
            }
            clear();
            loadCourseStudents();
        }

        private void dgvCourseStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourseStudent.CurrentRow != null)
            {
                courseStudent.StudentId = Convert.ToInt32(dgvCourseStudent.CurrentRow.Cells["dgStudentId"].Value);
                courseStudent.CourseId = Convert.ToInt32(dgvCourseStudent.CurrentRow.Cells["dgCourseId"].Value);
                using (MyContext db = new MyContext())
                {
                    courseStudent = db.CourseStudents.Find(courseStudent.StudentId, courseStudent.CourseId);
                    if (courseStudent != null)
                    {
                        cboStudent.SelectedValue = courseStudent.StudentId;
                        cboCourse.SelectedValue = courseStudent.CourseId;
                    }
                }
                btnDelete.Enabled = true;
            }
        }

        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStudent.SelectedIndex > 0 && cboStudent.SelectedValue != null && int.TryParse(cboStudent.SelectedValue.ToString(), out int StudentId))
                selectedStudent = StudentId;
            else
                selectedStudent = 0;
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex > 0 && cboCourse.SelectedValue != null && int.TryParse(cboCourse.SelectedValue.ToString(), out int CourseId))
                selectedCourse = CourseId;
            else
                selectedCourse = 0;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    courseStudent = db.CourseStudents.Find(selectedStudent, selectedCourse);
                    if (courseStudent != null)
                    {
                        db.CourseStudents.Remove(courseStudent);
                        db.SaveChanges();
                        clear();
                        loadCourseStudents();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudent.SelectedIndex == 0 || cboCourse.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            courseStudent.StudentId = selectedStudent;
            courseStudent.CourseId = selectedCourse;

            using (MyContext db = new MyContext())
            {
                var existing = db.CourseStudents
                    .FirstOrDefault(cs => cs.StudentId == courseStudent.StudentId && cs.CourseId == courseStudent.CourseId);

                if (existing == null)
                {
                    db.CourseStudents.Add(courseStudent);
                    MessageBox.Show("Course Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Course Student already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.SaveChanges();

            }

            loadCourseStudents();
            clear();
        }
    }
}
