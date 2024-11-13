using Microsoft.AspNetCore.Mvc;

namespace AVG.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
