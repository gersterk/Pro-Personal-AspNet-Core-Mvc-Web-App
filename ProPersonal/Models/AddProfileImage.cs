using Microsoft.AspNetCore.Http;

namespace ProPersonal.Models
{
    public class AddProfileImage
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriteAbout { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public IFormFile WriterImage { get; set; }
        public bool IsActiveWriter { get; set; }
    }
}

