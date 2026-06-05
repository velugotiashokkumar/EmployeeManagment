using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Length(5, 30)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is Required")]
        [Length(5, 11)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Position is Required")]
        public string Position { get; set; }
    }
}
