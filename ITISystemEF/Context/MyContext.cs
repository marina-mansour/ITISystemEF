using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITISystemEF.Models;
using ITISystemEF.Seeding;
using Microsoft.EntityFrameworkCore;

namespace ITISystemEF.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress;DataBase=ITISystemEF;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region PK
            modelBuilder.Entity<Student>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Course>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CourseSession>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CourseSessionAttendance>()
                .HasKey(c => c.Id);
            #endregion

            #region student:course m:m
            modelBuilder.Entity<Student>()
                .HasMany(s => s.CourseStudents)
                .WithOne(c => c.Student)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.CourseStudents)
                .WithOne(s => s.Course)
                .HasForeignKey(c => c.CourseId);
            #endregion

            #region student:courseSession m:m with Attribute
            modelBuilder.Entity<CourseSession>()
                .HasKey(cs => cs.Id);

            modelBuilder.Entity<CourseSessionAttendance>()
                .HasKey(csa => csa.Id);
            #endregion

            #region instructor:department 1:1 PP Manage
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.ManagedDepartment)
                .WithOne(d => d.Manager)
                .HasForeignKey<Department>(d => d.ManagerId)
                .IsRequired(false);
            #endregion

            #region instructor:department 1:m work
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region M:M without Attributes
            //            modelBuilder.Entity<Student>()
            //                .HasMany(s => s.Courses)
            //                .WithMany(c => c.Students)
            //                .UsingEntity(j => j.ToTable("Student_Courses")
            //                .HasData(new { CoursesId = 1, StudentsId = 2 },
            //new { CoursesId = 3, StudentsId = 4 },
            //new { CoursesId = 1, StudentsId = 3 },
            //new { CoursesId = 2, StudentsId = 4 }
            //));
            #endregion

            base.OnModelCreating(modelBuilder);

            #region Seeding
            var data = new InitialData();
            modelBuilder.Entity<Student>()
                    .HasData(data.Students);
            modelBuilder.Entity<Instructor>()
                    .HasData(data.Instructors);
            modelBuilder.Entity<Department>()
                    .HasData(data.Departments);
            modelBuilder.Entity<Course>()
                    .HasData(data.Courses);
            modelBuilder.Entity<CourseSession>()
                    .HasData(data.CourseSessions);
            modelBuilder.Entity<CourseSessionAttendance>()
                    .HasData(data.CourseSessionsAttendance);
            modelBuilder.Entity<CourseStudent>()
                    .HasData(data.StudentCourses);
            #endregion
        }


        #region Tables
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendance { get; set; }
        public virtual DbSet<CourseStudent> CourseStudents { get; set; }
        #endregion
    }
}
