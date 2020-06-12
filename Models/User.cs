using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models

{
    public class User
    {
        [Key]

        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter a First Name") ]
        [MinLength(4, ErrorMessage="Name must be more than 4 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        [MinLength(4, ErrorMessage="Must be more than 4 characters!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age must be greater than 0")]
        [Range(0, double.PositiveInfinity)]
        public int Age { get; set; }

        [Required(ErrorMessage=" Please provide an Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage="Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    } 
}