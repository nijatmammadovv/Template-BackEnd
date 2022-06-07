using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Data_Access_Layer;
using Template_BackEnd.Models;
using Template_BackEnd.ViewModels;

namespace Template_BackEnd.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                aboutSections = await _context.aboutSections.Where(abouts=>abouts.Name !=null).Take(1).ToListAsync(),
                ExperienceSections = await _context.ExperienceSections.ToListAsync(),
                EducationSections = await _context.EducationSections.Take(2).ToListAsync(),
                SkillsSections = await _context.SkillsSections.ToListAsync(),
                İnterestSections = await _context.İnterestSections.ToListAsync(),
                AwardsSections = await _context.AwardsSections.ToListAsync()
            };
            return View(homeVM);
        }

    }
}
