using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Models;

namespace Template_BackEnd.Data_Access_Layer
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<AboutSection> aboutSections { get; set; }
        public DbSet<ExperienceSection> ExperienceSections { get; set; }
        public DbSet<EducationSection> EducationSections { get; set; }
        public DbSet<SkillsSection> SkillsSections { get; set; }
        public DbSet<İnterestSection> İnterestSections { get; set; }
        public DbSet<AwardsSection> AwardsSections { get; set; }
    }
}
