using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectContenct { get; set; } //content :(
        public DateTime ProjectPublishDate { get; set; }

        public string ProjectImage { get; set; } //Main
        // I could not figure out how I could upload a set of images in project
        // And add them to the content
        // Thats why I will add a few images prop So I cant solve, will be able to load manually
        
        public string ProjectImage2 { get; set; }
        public string ProjectImage3 { get; set; }
        public string ProjectImage4 { get; set; }
        public bool IsActiveProject { get; set; }

    }
}
