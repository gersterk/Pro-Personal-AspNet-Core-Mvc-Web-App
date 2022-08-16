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
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogContent { get; set; }

        public string BlogThumnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsActiveBlog { get; set; }


        //To create a relation 
        public int CategoryId { get; set; }
        //CategoryId should be identical as we have engaged the categories to the blog
        public Category Category { get; set; }
        //We derive a category from category class
        //to provide the categoryid to Blogs
        //blogs will be listing the categories
        //to have this relationships on dataserver(sql) too, we should apply migration

        List<CommentMail> CommentMails { get; set; }



        public int WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}
