using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITISystemEF.Models;

namespace ITISystemEF.Seeding
{
    public class InitialData
    {
        public IReadOnlyList<Department> Departments { get; }
        public IReadOnlyList<Course> Courses { get; }
        public IReadOnlyList<Instructor> Instructors { get; }
        public IReadOnlyList<Student> Students { get; }
        public IReadOnlyList<CourseSession> CourseSessions { get; }
        public IReadOnlyList<CourseSessionAttendance> CourseSessionsAttendance { get; }
        public IReadOnlyList<CourseStudent> StudentCourses { get; }

        public InitialData()
        {
            Departments = new List<Department>
            {
                new() {DepartmentId = 1, Name = "SD", Location = "Ism", ManagerId = 4},
                new() {DepartmentId = 2, Name = "UI", Location = "Smart", ManagerId = 3},
                new() {DepartmentId = 3, Name = "WC", Location = "New Capital", ManagerId = 2},
                new() {DepartmentId = 4, Name = "DE", Location = "Cairo", ManagerId = 1}
            };

            Courses = new List<Course>
            {
                new() {Id = 1, Name = "MVC", Duration = 12, DepartmentId = 1, InstructorId = 4},
                new() {Id = 2, Name = "EF", Duration = 3, DepartmentId = 3, InstructorId = 2},
                new() {Id = 3, Name = "React", Duration = 4, DepartmentId = 2, InstructorId = 1},
                new() {Id = 4, Name = "iOS", Duration = 6, DepartmentId = 4, InstructorId = 3}
            };

            Instructors = new List<Instructor>
            {
                new() {InstructorId = 1, FName = "Mai", LName = "Moustafa", Phone = "01156894563"},
                new() {InstructorId = 2, FName = "Mohamed", LName = "Hatem", Phone = "01234567891"},
                new() {InstructorId = 3, FName = "Mo'men", LName = "Sherief", Phone = "01023456879"},
                new() {InstructorId = 4, FName = "Jamal", LName = "Ali", Phone = "0124578412"}
            };

            Students = new List<Student>
            {
                new() {Id = 1, FName = "Marina", LName = "Mansour", Phone = "01208978713"},
                new() {Id = 2, FName = "Bassem", LName = "Mohamed", Phone = "01547963145"},
                new() {Id = 3, FName = "Ammar", LName = "Attef", Phone = "01023457865"},
                new() {Id = 4, FName = "Kholoud", LName = "Ahmed", Phone = "01147583256"}
            };

            CourseSessions = new List<CourseSession>
            {
                new() {Id = 1, Title = "Day 01", Date = new DateTime(2020, 5, 13), CourseId = 1, InstructorId = 1},
                new() {Id = 2, Title = "Day 02", Date = new DateTime(2020, 10, 19), CourseId = 2, InstructorId = 4},
                new() {Id = 3, Title = "Day 03", Date = new DateTime(2020, 10, 25), CourseId = 4, InstructorId = 3},
                new() {Id = 4, Title = "Day 04", Date = new DateTime(2020, 6, 30), CourseId = 3, InstructorId = 2}
            };

            CourseSessionsAttendance = new List<CourseSessionAttendance>
            {
                new() {Id = 1, Grade = 10, Notes = "Excellent", StudentId = 1, CourseSessionId = 1},
                new() {Id = 2, Grade = 9, Notes = "Good", StudentId = 2, CourseSessionId = 2},
                new() {Id = 3, Grade = 8, Notes = "Satisfactory", StudentId = 3, CourseSessionId = 3},
                new() {Id = 4, Grade = 5, Notes = "Needs Improvement", StudentId = 4, CourseSessionId = 4}
            };

            StudentCourses = new List<CourseStudent>
            {
                new() {CourseId = 1, StudentId = 2},
                new() {CourseId = 3, StudentId = 4},
                new() {CourseId = 1, StudentId = 3},
                new() {CourseId = 2, StudentId = 4}
            };
        }
    }
}
