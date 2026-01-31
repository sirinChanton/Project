using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class ConfirmSellerController : Controller
{
    public IActionResult Confirm_Seller()
    {
        return View();
    }
}

