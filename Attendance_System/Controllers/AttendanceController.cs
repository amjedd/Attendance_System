using Microsoft.AspNetCore.Mvc;

namespace Attendance_System.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
