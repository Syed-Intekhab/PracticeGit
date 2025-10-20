using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Id is required!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(50, ErrorMessage = "Please enter less than 50 characters!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [StringLength(30, ErrorMessage = "Please enter less than 30 characters!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Course is required!")]
        [StringLength(50, ErrorMessage = "Please enter less than 50 characters!")]
        public string? Course { get; set; }
    }
}
