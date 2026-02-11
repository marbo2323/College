using System.ComponentModel.DataAnnotations;

namespace College.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }
        public Department? Department { get; set; }
        public int? DepartmentID { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }

        public ICollection<CourseAssignment>? courseAssignments { get; set; }

    }
}