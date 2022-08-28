using System.ComponentModel.DataAnnotations;

namespace ProPersonal.Models
{
    public class UserRegisterModel
    {
        [Display(Name= "Name Surname")]
        [Required (ErrorMessage ="Please input name and surname!")]
        public string NameSurname { get; set; }

        [Display(Name= "Password")]
        [Required(ErrorMessage="Please input a password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "Passwords do not match!") ]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Address")]
        [Required(ErrorMessage ="Please input a mail address")]
        public string Mail { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please input a username")]
        public string UserName { get; set; }
    }
}
