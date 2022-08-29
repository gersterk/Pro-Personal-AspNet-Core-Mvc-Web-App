using System.ComponentModel.DataAnnotations;

namespace ProPersonal.Models
{
    public class RoleModel
    {
        [Required(ErrorMessage = "Give a Role")]
        public string name { get; set; }
    }
}
