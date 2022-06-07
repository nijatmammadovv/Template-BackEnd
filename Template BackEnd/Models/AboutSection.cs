using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_BackEnd.Models
{
    public class AboutSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string NumbervsAdress { get; set; }
        public string Description { get; set; }
    }
}
