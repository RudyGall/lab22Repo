using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace CoffeeShopLab.Models
{
    public class RegisterUser
    {
        public RegisterUser()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            PassWord = "";
            Date = "";
            Age = "";
            SSN = "";
        }
        public RegisterUser(string firstName, string lastName, string email, string phoneNumber, string password, string date, string age, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PassWord = password;
            Date = date;
            Age = age;
            SSN = ssn;
        }
        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        [Display(Name ="First Name")]
        public string FirstName { get; set;  }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{5,30}(@)(.+){5,10}$")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email{ get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$")]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]$|^[1-9][0-9]$|^(100)$")]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-?\d{2}-?\d{4}$")]
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber{ get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]\w{3,14}$")]
        [Display(Name = "PassWord ")]
        public string PassWord { get; set; }

        [Required]
        [Display(Name = "Please verify the information is correct")]
        public string Verify { get; set; }
    }
}