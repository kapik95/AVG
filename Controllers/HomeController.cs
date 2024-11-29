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

        public async Task<IActionResult> Details(int id)
        {
            var project = await _context.ProjectsModel.FirstOrDefaultAsync(a => a.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            var projectResponse = new ProjectDataResponse
            (
                project.Id,
                project.Title,
                project.Description,
                project.ImagePath,
                project.ExampleScript
            );
            return View(projectResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}