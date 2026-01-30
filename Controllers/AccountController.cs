using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class AccountController : Controller
{
    // สิ่งนี้คือ router ถ้ามีเพิ่มก็ใส่เพิ่มได้
    public IActionResult Test1()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Title"] = "Privacy Policy";
        return View();
    }

    public IActionResult Lab4()
    {
        ViewData["Title"] = "Lab4";
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
