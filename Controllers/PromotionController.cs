using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class PromotionController : Controller
{
    public IActionResult Promotion_Page()
    {
        return View();
    }
}