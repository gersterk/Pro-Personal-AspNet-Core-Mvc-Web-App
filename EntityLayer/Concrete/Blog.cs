using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This Entity as a class represents the table in our database
//if this be so the properties are the columns
namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogContent { get; set; }

        public string BlogThumnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsActiveBlog { get; set; }
    }
}
