using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        public Instructor Manager { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public override string ToString()
        {
            return $"Id: {DepartmentId}, Name: {Name}, Location: {Location}, ManagerId: {ManagerId}";
        }
    }
}
