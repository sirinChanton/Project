using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class ManagerController : Controller
{
    [HttpGet]
    public IActionResult Manage_User()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddUser(string username, string tel, string email)
    {
        // TODO: save user to database
        // ตอนนี้ยังไม่ต่อ DB

        return RedirectToAction("ManageUser");
    }
}
