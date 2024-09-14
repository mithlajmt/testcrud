using System.ComponentModel.DataAnnotations;

namespace examcrud.Models.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string HashedPass { get; set; }

    }
}
