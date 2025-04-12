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

namespace ITISystemEF.UserControls
{
    public partial class UC_CourseSessions : UserControl
    {
        CourseSession courseSession = new CourseSession();
        private int selectedCourse = 0;
        private int selectedInstructor = 0;
        public UC_CourseSessions()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtTitle.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            courseSession.Id = 0;
            cboCourse.SelectedIndex = 0;
            cboInstructor.SelectedIndex = 0;
        }
        void loadCourseSessions()
        {
            dgvCourseSessions.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var courseSessions = db.CourseSessions
                    .Select(cs => new
                    {
                        cs.Id,
                        cs.Title,
                        cs.Date,
                        Course = cs.Course.Name,
                        Instructor = cs.Instructor.FName + " " + cs.Instructor.LName
                    })
                    .ToList();
                dgvCourseSessions.DataSource = courseSessions;
            }
        }
        private void UC_CourseSessions_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTitle;
            using (MyContext db = new MyContext())
            {
                var courses = db.Courses
                    .Select(c => new { c.Id, c.Name })
                    .ToList();
                courses.Insert(0, new { Id = 0, Name = "-- Select Course --" });
                cboCourse.DataSource = courses;
                cboCourse.DisplayMember = "Name";
                cboCourse.ValueMember = "Id";
                cboCourse.SelectedIndex = 0;

                var instructors = db.Instructors
                    .Select(i => new { i.InstructorId, FullName = i.FName + " " + i.LName })
                    .ToList();
                instructors.Insert(0, new { InstructorId = 0, FullName = "-- Select Instructor --" });
                cboInstructor.DataSource = instructors;
                cboInstructor.DisplayMember = "FullName";
                cboInstructor.ValueMember = "InstructorId";
                cboInstructor.SelectedIndex = 0;
            }
            clear();
            loadCourseSessions();
        }

        private void dgvCourseSessions_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourseSessions.CurrentRow != null)
            {
                courseSession.Id = Convert.ToInt32(dgvCourseSessions.CurrentRow.Cells["dgCourseSessionId"].Value);

                using (MyContext db = new MyContext())
                {
                    courseSession = db.CourseSessions.Find(courseSession.Id);
                    if (courseSession != null)
                    {
                        txtTitle.Text = courseSession.Title;
                        dtpDate.Value = courseSession.Date;
                        cboCourse.SelectedValue = courseSession.CourseId;
                        cboInstructor.SelectedValue = courseSession.InstructorId;
                        btnSave.Text = "Update";
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex > 0 && cboCourse.SelectedValue != null && int.TryParse(cboCourse.SelectedValue.ToString(), out int courseId))
                selectedCourse = courseId;
            else
                selectedCourse = 0;
        }

        private void cboInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInstructor.SelectedIndex > 0 && cboInstructor.SelectedValue != null && int.TryParse(cboInstructor.SelectedValue.ToString(), out int instructorId))
                selectedInstructor = instructorId;
            else
                selectedInstructor = 0;
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || selectedCourse == 0 || selectedInstructor == 0)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            courseSession.Title = txtTitle.Text;
            courseSession.Date = dtpDate.Value;
            courseSession.CourseId = selectedCourse;
            courseSession.InstructorId = selectedInstructor;

            using (MyContext db = new MyContext())
            {
                if (courseSession.Id == 0 && btnSave.Text == "Save")
                {
                    db.CourseSessions.Add(courseSession);
                    db.SaveChanges();
                    MessageBox.Show("Course Session added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.CourseSessions.Update(courseSession);
                    db.SaveChanges();
                    MessageBox.Show("Course Session updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            clear();
            loadCourseSessions();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this CourseSession?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    courseSession = db.CourseSessions.Find(courseSession.Id);
                    if (courseSession != null)
                    {
                        db.CourseSessions.Remove(courseSession);
                        db.SaveChanges();
                        MessageBox.Show("CourseSession deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clear();
                loadCourseSessions();
            }
        }
    }
}
