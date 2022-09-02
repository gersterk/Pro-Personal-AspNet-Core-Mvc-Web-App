using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BusinessCard
    {
        [Key]
        public int Id { get; set; }
        public string Profession { get; set; }
        public string SelfDescription { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
