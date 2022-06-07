using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Data_Access_Layer;
using Template_BackEnd.Models;

namespace Template_BackEnd.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AboutController : Controller
    {
        private AppDbContext _context { get; }
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AboutSection> AboutSections = _context.aboutSections.ToList();
            return View(AboutSections);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutSection about)
        {
            await _context.aboutSections.AddAsync(about);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            AboutSection aboutSection = _context.aboutSections.Find(id);
            if (aboutSection == null) return NotFound();
            if(aboutSection != null)
            {
                _context.aboutSections.Remove(aboutSection);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            AboutSection aboutSection = _context.aboutSections.FirstOrDefault(about => about.Id == id);
            if (aboutSection == null) return NotFound();
            return View(aboutSection);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutSection about)
        {
            AboutSection aboutSection1 = _context.aboutSections.FirstOrDefault(about1 => about1.Id == about.Id);
            if (aboutSection1 == null) return NotFound();
            aboutSection1.Name = about.Name;
            aboutSection1.Surname = about.Surname;
            aboutSection1.Email = about.Email;
            aboutSection1.NumbervsAdress = about.NumbervsAdress;
            aboutSection1.Description = about.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
