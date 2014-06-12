using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RibbitMvc.ViewModel
{
    public class CreateRibbitViewModel
    {
        [Required]
        [MaxLength(140,ErrorMessage="Status can t be not more than 140 characters.")]
        public string Status { get; set; }
    }
}