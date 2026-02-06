using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class DashboardController : Controller
{
    public IActionResult Dash_Board(string Username, string Password)
    {
        ViewBag.Username = Username;
        ViewBag.Password = Password;
        return View();
    }
}
