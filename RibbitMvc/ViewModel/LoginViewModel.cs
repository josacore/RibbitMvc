using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RibbitMvc.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Please enter your Username.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your Password.")]
        public string Password { get; set; }
    }
}