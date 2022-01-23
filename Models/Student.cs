using System.ComponentModel.DataAnnotations;

namespace POCApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public string Major { get; set; }

    }
}
