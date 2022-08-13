using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//There will a comment section but I dont want to use that
//I to use that as a mail comment to receive comments as mail
//will not be monitored on the page...

namespace EntityLayer.Concrete
{
    public class CommentMail
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentContent { get; set; } 
        public string CommentTitle { get; set; }
        //comment title will be merged with PROPERSONAL:<user title>
        //to my mail box with the title... I have no idea how to do that yet but I will figure it out

        public DateTime CommentDate { get; set; }

        public bool IsActiveComment { get; set; }

        public int BlogId { get; set; }
        public Blog Blogs { get; set; }

        
    }
}
