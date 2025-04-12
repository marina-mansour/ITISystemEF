using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; } /////////////////////////////////////////////////////////////////

        public Department Department { get; set; } = null!;
        public Department ManagedDepartment { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

        public override string ToString()
        {
            return $"Id: {InstructorId}, Name: {FName} {LName}, Phone: {Phone}";
        }
    }
}
