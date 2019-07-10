using System;
using System.ComponentModel.DataAnnotations;
namespace SimpleLoginReg.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string LoginEmail {get;set;}
        [Required (ErrorMessage = "Enter valid email")]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}
    }
}