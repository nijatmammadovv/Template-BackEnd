using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Models;

namespace Template_BackEnd.ViewModels
{
    public class HomeVM
    {
        public List<AboutSection> aboutSections { get; set; }
        public List<ExperienceSection> ExperienceSections { get; set; }
        public List<EducationSection> EducationSections { get; set; }
        public List<SkillsSection> SkillsSections { get; set; }
        public List<İnterestSection> İnterestSections { get; set; }
        public List<AwardsSection> AwardsSections { get; set; }
    }
}
