namespace College.Models
{
    public enum Grade
    {
        A,B,C,D,F,X,MA
    }
    public class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? CurrentGrade { get; set; }

        public required Course Course { get; set; }
        public required Student Student { get; set; }
    }
}