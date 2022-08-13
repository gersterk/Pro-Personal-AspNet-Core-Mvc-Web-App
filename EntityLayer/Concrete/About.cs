using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        public int AbooutId { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }

        public string AboutMapLocation { get; set; }
        //here I just want to try to use Map api and some frames. 
        //nothing speacial. will see if its gonna work out
        public bool IsActiveAbout { get; set; }

    }
}
