using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_BackEnd.Models
{
    public class AwardsSection
    {
        public int Id { get; set; }
        [Required]
        public string  AwardName { get; set; }
        public string RowNumbers { get; set; }
        [Required]
        public int  AwardDegree { get; set; }

    }
}
