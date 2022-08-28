using System.ComponentModel.DataAnnotations;

namespace ProPersonal.Models
{
    public class UserLoginModel
    {

       
        [Required(ErrorMessage = "Please input your mail!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please input your password!")]
        public string UserPassword { get; set; }
    }
}
