using System.ComponentModel.DataAnnotations;

namespace examcrud.Models.Dtos
{
    public class EmployeeDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        [MinLength(3, ErrorMessage = "First Name must be at least 3 characters long")]
        public string? FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "last Name cannot exceed 50 characters")]
        [MinLength(3, ErrorMessage = "last Name must be at least 3 characters long")]
        public string? LastName { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; } = "";

        [Required(ErrorMessage = "Phone Number is required")]
        public string? PhoneNumber { get; set; } = "";

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; } = "";

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; } = "";
    }
}
