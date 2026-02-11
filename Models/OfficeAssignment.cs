using System.ComponentModel.DataAnnotations;

namespace College.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Kabinet")]
        public required string Location { get; set; }
    }
}