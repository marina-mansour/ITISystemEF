using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //m:m student:course
        //public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

        //1:m instructor:Course
        public Instructor Instructor { get; set; } = null!;

        //1:m department:Course
        public Department Department { get; set; } = null!;

        public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new HashSet<CourseStudent>();

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
