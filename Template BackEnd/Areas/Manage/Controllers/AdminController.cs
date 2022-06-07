using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_BackEnd.Data_Access_Layer;

namespace Template_BackEnd.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
