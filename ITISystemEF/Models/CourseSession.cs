using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class CourseSession
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }

        //m:m student:courseSession => with Attribute
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new List<CourseSessionAttendance>();

        public virtual Course Course { get; set; } = null!; //virtual lazy loading
        public virtual Instructor Instructor { get; set; } = null!;

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Date: {Date}";
        }
    }
}

