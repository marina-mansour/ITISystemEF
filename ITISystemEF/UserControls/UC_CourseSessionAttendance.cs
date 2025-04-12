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
    public partial class UC_CourseSessionAttendance : UserControl
    {
        CourseSessionAttendance courseSessionAttendance = new CourseSessionAttendance();
        private int selectedCourseSession = 0;
        private int selectedStudent = 0;
        public UC_CourseSessionAttendance()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtGrade.Text = txtNotes.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            courseSessionAttendance.Id = 0;
            cboCourseSession.SelectedIndex = 0;
            cboStudent.SelectedIndex = 0;
        }
        void loadCourseSessionAttendances()
        {
            dgvCourseSessionAttendance.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var courseSessionAttendances = db.CourseSessionAttendance
                    .Select(csa => new
                    {
                        csa.Id,
                        csa.Grade,
                        csa.Notes,
                        CourseSession = csa.CourseSession.Title,
                        Student = csa.Student.FName + " " + csa.Student.LName
                    })
                    .ToList();
                dgvCourseSessionAttendance.DataSource = courseSessionAttendances;
            }
        }
        private void UC_CourseSessionAttendance_Load(object sender, EventArgs e)
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

                var courseSessions = db.CourseSessions
                    .Select(cs => new { cs.Id, cs.Title })
                    .ToList();
                courseSessions.Insert(0, new { Id = 0, Title = "-- Select Course Session --" });
                cboCourseSession.DataSource = courseSessions;
                cboCourseSession.DisplayMember = "Title";
                cboCourseSession.ValueMember = "Id";
                cboCourseSession.SelectedIndex = 0;

            }
            clear();
            loadCourseSessionAttendances();

        }
        private void dgvCourseSessionAttendance_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourseSessionAttendance.CurrentRow != null)
            {
                courseSessionAttendance.Id = Convert.ToInt32(dgvCourseSessionAttendance.CurrentRow.Cells["dgCourseSessionAttendanceId"].Value);

                using (MyContext db = new MyContext())
                {
                    courseSessionAttendance = db.CourseSessionAttendance.Find(courseSessionAttendance.Id);
                    if (courseSessionAttendance != null)
                    {
                        cboCourseSession.SelectedValue = courseSessionAttendance.CourseSessionId;
                        cboStudent.SelectedValue = courseSessionAttendance.StudentId;
                        txtGrade.Text = courseSessionAttendance.Grade.ToString();
                        txtNotes.Text = courseSessionAttendance.Notes;
                    }
                }
                btnSave.Text = "Update";
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
        private void cboCourseSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourseSession.SelectedIndex > 0 && cboCourseSession.SelectedValue != null && int.TryParse(cboCourseSession.SelectedValue.ToString(), out int CourseSessionId))
                selectedCourseSession = CourseSessionId;
            else
                selectedCourseSession = 0;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    var courseSessionAttendanceToDelete = db.CourseSessionAttendance.Find(courseSessionAttendance.Id);
                    if (courseSessionAttendanceToDelete != null)
                    {
                        db.CourseSessionAttendance.Remove(courseSessionAttendanceToDelete);
                        db.SaveChanges();
                        MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                loadCourseSessionAttendances();
                clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrade.Text) || selectedCourseSession == 0 || selectedStudent == 0)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            courseSessionAttendance.Grade = Convert.ToInt32(txtGrade.Text);
            courseSessionAttendance.Notes = txtNotes.Text;
            courseSessionAttendance.CourseSessionId = selectedCourseSession;
            courseSessionAttendance.StudentId = selectedStudent;

            using (MyContext db = new MyContext())
            {
                if (courseSessionAttendance.Id == 0 && btnSave.Text == "Save")
                {
                    db.CourseSessionAttendance.Add(courseSessionAttendance);
                    db.SaveChanges();
                    MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.CourseSessionAttendance.Update(courseSessionAttendance);
                    db.SaveChanges();
                    MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            loadCourseSessionAttendances();
            clear();
        }
    }
}
