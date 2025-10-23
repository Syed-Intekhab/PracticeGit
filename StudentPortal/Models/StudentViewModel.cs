using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models
{
    public class StudentViewModel
    {
        public required Student StudentInfo { get; set; } // From Student Model

        [Required(ErrorMessage = "Please select at least one course.")]
        public required List<string> Courses { get; set; } // Dropdown list of courses

        [DisplayName("Is Top Student")]
        public bool IsTopStudent { get; set; } // Indicates if the student is a top performer
    }
}
