using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; } //monitors if the environment or the portfolio has any extra description
        public string Image { get; set; }
     
    }
}
