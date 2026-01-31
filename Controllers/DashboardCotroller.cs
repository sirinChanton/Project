// Controllers/DashboardController.cs
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class DashboardController : Controller
{
    public IActionResult DashBoard()
    {
        return View();
    }
}
