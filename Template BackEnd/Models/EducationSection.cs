using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_BackEnd.Models
{
    public class EducationSection
    {
        public int Id { get; set; }
        [Required]
        public string UniversityName { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        public string AverageScore { get; set; }
        [Required]
        public string PresentationHistory { get; set; }
    }
}
