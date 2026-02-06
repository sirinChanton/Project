using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string fullname, string tel, string email, string username, string password)
    {
        // TODO: บันทึกข้อมูลลง DB
        // ตอนนี้สมมติว่าลงทะเบียนสำเร็จ
        return RedirectToAction("Login");
    }
}

}