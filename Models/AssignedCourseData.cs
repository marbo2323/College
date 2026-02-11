namespace College.Models
{
    public class AssignedCourseData
    {
        public int CourseID { get; set; }
        public required string Title { get; set; }
        public bool Assigned { get; set; }
    }
}