using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RibbitMvc.ViewModel
{
    public class EditProfileViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please enter the email adrress.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage="Please enter you name.")]
        public string Name { get; set; }
        [Url(ErrorMessage="please enter a valid  URL.")]
        [DataType(DataType.Url)]
        public string Website { get; set; }
        [MaxLength(140,ErrorMessage="The Bio only can be less than {0} characters.")]
        public string Bio { get; set; }
        public string EmailHash { get; set; }
    }
}