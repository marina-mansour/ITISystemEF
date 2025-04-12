using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITISystemEF.Models
{
    public class CourseSessionAttendance
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("CourseSession")]
        public int CourseSessionId { get; set; }
        public int Grade { get; set; }
        public string? Notes { get; set; }

        //m:m student:course_session => with Attribute
        public virtual Student Student { get; set; } = null!;
        public virtual CourseSession CourseSession { get; set; } = null!;

        public override string ToString()
        {
            return $"Id: {Id}, Grade: {Grade}, Notes: {Notes}, StudentId: {StudentId}, CourseSessionId: {CourseSessionId}";
        }
    }
}
