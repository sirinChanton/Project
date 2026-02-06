using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        // แสดงหน้า Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // รับค่าจากฟอร์ม Login
        [HttpPost]
        public IActionResult Login(LabUserViewModel model)
        {
            return RedirectToAction("Dash_Board","Dashboard", new { username = model.Username,password = model.Password });
        }

        // หน้า Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
