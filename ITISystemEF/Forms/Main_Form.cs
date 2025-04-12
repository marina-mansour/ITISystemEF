using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITISystemEF.UserControls;

namespace ITISystemEF.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            UC_Students uc = new UC_Students();
            addUserControl(uc);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void BtnStudents_Click(object sender, EventArgs e)
        {
            UC_Students uc = new UC_Students();
            addUserControl(uc);
        }


        private void BtnInstructors_Click(object sender, EventArgs e)
        {
            UC_Instructors uc = new UC_Instructors();
            addUserControl(uc);
        }

        private void BtnDepartments_Click(object sender, EventArgs e)
        {
            UC_Departments uc = new UC_Departments();
            addUserControl(uc);
        }

        private void BtnCourses_Click(object sender, EventArgs e)
        {
            UC_Courses uc = new UC_Courses();
            addUserControl(uc);
        }

        private void BtnCourseSession_Click(object sender, EventArgs e)
        {
            UC_CourseSessions uc = new UC_CourseSessions();
            addUserControl(uc);
        }

        private void BtnCourseSessionAttendance_Click(object sender, EventArgs e)
        {
            UC_CourseSessionAttendance uc = new UC_CourseSessionAttendance();
            addUserControl(uc);
        }

        private void BtnCourseStudents_Click(object sender, EventArgs e)
        {
            UC_CourseStudents uc = new UC_CourseStudents();
            addUserControl(uc);
        }

        //private void BtnStudents_Click(object sender, EventArgs e)
        //{

        //}
    }
}
