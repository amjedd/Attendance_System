using Microsoft.AspNetCore.Mvc;

namespace Attendance_System.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
