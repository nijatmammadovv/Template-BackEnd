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
    public class EducationController : Controller
    {
        private AppDbContext _context { get; }
        public EducationController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<EducationSection> educationSections = _context.EducationSections.ToList();
            return View(educationSections);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EducationSection education)
        {
            if(_context.EducationSections.FirstOrDefault(edu => edu.UniversityName.ToLower().Trim() == education.UniversityName.ToLower().Trim()) != null) return RedirectToAction(nameof(Index));
            await _context.EducationSections.AddAsync(education);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            EducationSection educationSection = _context.EducationSections.Find(id);
            if (educationSection == null) return NotFound();
            if (educationSection != null)
            {
                _context.EducationSections.Remove(educationSection);
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
        public IActionResult Update(EducationSection education)
        {
            EducationSection educationSection = _context.EducationSections.FirstOrDefault(edu => edu.Id == education.Id);
            if (educationSection == null) return NotFound();
            educationSection.UniversityName = education.UniversityName;
            educationSection.Degree = education.Degree;
            educationSection.Specialty = education.Specialty;
            educationSection.AverageScore = education.PresentationHistory;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
