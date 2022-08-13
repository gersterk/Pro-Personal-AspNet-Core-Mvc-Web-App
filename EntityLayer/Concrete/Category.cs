using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//This Entity as a class represents the table in our database
//if this be so the properties are the columns
namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public bool IsActiveCategory { get; set; }
    } 
}

