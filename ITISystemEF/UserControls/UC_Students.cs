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
using Microsoft.EntityFrameworkCore;

namespace ITISystemEF.UserControls
{
    public partial class UC_Students : UserControl
    {
        Student student = new Student();
        public UC_Students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        void clear()
        {
            txtFirstName.Text = txtLastName.Text = txtPhone.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            student.Id = 0;
        }

        private void btnDelete_CLick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                student.Id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["dgStudentID"].Value);
                using (MyContext db = new MyContext())
                {
                    //var entry = db.Entry(student);
                    //if (entry.State == EntityState.Detached)
                    //{
                    //    db.Students.Attach(student);
                    //    db.Students.Remove(student);
                    //    db.SaveChanges();
                    //    LoadStudents();
                    //    clear();
                    //    MessageBox.Show("Student Deleted Successfully");
                    //}
                    //-----------------
                    student = db.Students.Where(s => s.Id == student.Id).FirstOrDefault();
                    db.Students.Remove(student);
                    db.SaveChanges();
                    LoadStudents();
                    clear();
                    MessageBox.Show("Student Deleted Successfully");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            student.FName = txtFirstName.Text.Trim();
            student.LName = txtLastName.Text.Trim();
            student.Phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(student.FName) || string.IsNullOrEmpty(student.LName) || string.IsNullOrEmpty(student.Phone))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MyContext db = new MyContext())
            {
                //if (student.Id == 0)
                //    db.Students.Add(student);

                //else
                //    db.Entry(student).State = EntityState.Modified;
                //db.SaveChanges();
                //--------------------------
                if (btnSave.Text == "Save" && student.Id == 0)
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Student Added Successfully");
                }
                else
                {
                    db.Students.Update(student);
                    db.SaveChanges();
                    LoadStudents();
                    MessageBox.Show("Student Updated Successfully");
                }
            }
            clear();
            //LoadStudents();
            //MessageBox.Show("Student Submitted Successfully");

        }

        void LoadStudents()
        {
            dgvStudents.AutoGenerateColumns = false;
            using (MyContext db = new MyContext())
            {
                var students = db.Students.ToList();
                dgvStudents.DataSource = students;
            }
        }

        private void UC_Students_Load(object sender, EventArgs e)
        {
            clear();
            this.ActiveControl = txtFirstName;
            LoadStudents();
        }

        private void dgvStudents_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow.Index != -1)
            {
                student.Id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["dgStudentID"].Value);
                using (MyContext db = new MyContext())
                {
                    student = db.Students.Where(s => s.Id == student.Id).FirstOrDefault();
                    txtFirstName.Text = student.FName;
                    txtLastName.Text = student.LName;
                    txtPhone.Text = student.Phone;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
