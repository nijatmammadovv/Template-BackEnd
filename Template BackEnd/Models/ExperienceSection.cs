using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_BackEnd.Models
{
    public class ExperienceSection
    {
        public int Id { get; set; }
        [Required]
        public string SpecialtyName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PresentationHistory { get; set; }
    }
}
