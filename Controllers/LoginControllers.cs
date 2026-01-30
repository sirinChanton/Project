using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

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
        public IActionResult Login(string username, string password)
        {
            // ตัวอย่าง logic login
            if (username == "admin" && password == "1234")
            {
                return RedirectToAction("Lab4", "Home");
            }

            ViewBag.Error = "Username หรือ Password ไม่ถูกต้อง";
            return View();
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
