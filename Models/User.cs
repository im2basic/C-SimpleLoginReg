using System;
using System.ComponentModel.DataAnnotations;


namespace SimpleLoginReg.Models
{
    public class User
    {
    [Required (ErrorMessage = " Need first name ")]
    [MinLength(2)]
    [Display(Name = "First Name")]
    public string FirstName {get;set;}
    [Required (ErrorMessage = " Need Last name ")]
    [MinLength(2)]
    [Display(Name = " Last Name")]

    public string LastName {get;set;}
    [Required (ErrorMessage = "Enter Valid Email")]
    [EmailAddress]
    [Display(Name = " Email")]
    public string Email {get;set;}
    [Required]
    [MinLength(6)]
    [Display(Name = " Password")]
    [DataType(DataType.Password)]
    public string Password {get;set;}
    [Required]
    [MinLength(6)]
    [Display(Name = " Confirm Password")]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword {get;set;}


    }
}