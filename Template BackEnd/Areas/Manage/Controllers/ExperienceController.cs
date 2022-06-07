using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Data_Access_Layer;
using Template_BackEnd.Models;

namespace Template_BackEnd.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ExperienceController : Controller
    {
        private AppDbContext _context { get; }
        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ExperienceSection> ExperienceSections = _context.ExperienceSections.ToList();
            return View(ExperienceSections);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]       
        public async Task<IActionResult> Create(ExperienceSection experience)
        {
            if (_context.ExperienceSections.FirstOrDefault(e => e.SpecialtyName.ToLower().Trim() == experience.SpecialtyName.ToLower().Trim()) != null) return RedirectToAction(nameof(Index));
            await _context.ExperienceSections.AddAsync(experience);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            ExperienceSection ExperienceSections = _context.ExperienceSections.Find(id);
            if (ExperienceSections == null) return NotFound();
            if (ExperienceSections != null)
            {
                _context.ExperienceSections.Remove(ExperienceSections);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            ExperienceSection experienceSection = _context.ExperienceSections.FirstOrDefault(experience => experience.Id == id);
            if (experienceSection == null) return NotFound();
            return View(experienceSection);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExperienceSection experience)
        {
            ExperienceSection experienceSection = _context.ExperienceSections.FirstOrDefault(exp => exp.Id == experience.Id);
            if (experienceSection == null) return NotFound();
            experienceSection.SpecialtyName = experience.SpecialtyName;
            experienceSection.Title = experience.Title;
            experienceSection.Description = experience.Description;
            experienceSection.PresentationHistory = experience.PresentationHistory;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
