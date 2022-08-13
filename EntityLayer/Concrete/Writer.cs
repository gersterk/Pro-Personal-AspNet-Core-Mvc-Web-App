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
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriteAbout { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterImage { get; set; }
        public bool IsActiveWriter { get; set; }
    }
}
