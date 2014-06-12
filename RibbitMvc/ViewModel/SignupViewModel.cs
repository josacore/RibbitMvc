using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RibbitMvc.ViewModel
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Please enter your desired Username.")]
        public string Username { get; set; }
        [Required(ErrorMessage="Please enter the Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage="The Password does not match.")]
        [DataType(DataType.Password)]
        public string Password2 { get; set; }
        [Required(ErrorMessage="Please enter an Email.")]
        [DataType(DataType.EmailAddress,ErrorMessage="Please enter a valid Email Address.")]
        public string Email { get; set; }
    }
}