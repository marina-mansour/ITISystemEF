using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string? Phone { get; set; }

        //m:m student:course
        //public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        //m:m student:courseSession => with Attribute
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new List<CourseSessionAttendance>();

        public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new HashSet<CourseStudent>();



        public override string ToString()
        {
            return $"Id: {Id}, Name: {FName} {LName}, Phone: {Phone}";
        }

    }
}
