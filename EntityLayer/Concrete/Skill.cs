using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; } // will get inputs of // processing, promising, strong
        public bool IsActive { get; set; } // will get inputs of // processing, promising, strong

        public string RelatedProjectLink { get; set; } // if needed, I will try to link to the projects that was parsed by the skills.
        //articulabely will navigate the client to the projects that the skill contains
    }
}
