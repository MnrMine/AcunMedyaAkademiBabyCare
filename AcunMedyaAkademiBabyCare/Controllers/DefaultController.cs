using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
