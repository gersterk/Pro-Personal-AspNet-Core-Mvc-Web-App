using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Class of experience entity. /Resume
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Gain { get; set; }
        public string CompanyName { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public bool IsActive { get; set; }
        public string Icon { get; set; } // to assign some nice icons if oneday Id like to 


    }
}
