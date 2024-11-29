using AVG.Contracts;
using AVG.Data;
using AVG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AVG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectsDbContext _context;

        public HomeController(ProjectsDbContext context)
        {
            _context = context;
        }

        /*public async Task<IActionResult> Index()
        {
            var projects = await _context.ProjectsModel.ToListAsync();
            return View(projects);
            //return View();
        }*/

        public async Task<IActionResult> Index()
        {
            var projects = await _context.ProjectsModel
                .Select (a => new ProjectsResponse(
                    a.Id,
                    a.Title,
                    a.BriefDescription,
                    a.ImagePath))
                .ToListAsync(); 
            return View(projects);
        }

        public IActionResult InformationSecurity()
        { 
            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}