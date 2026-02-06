using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.ViewModels;

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
    
    public IActionResult Lab5()
    {
        // แบบเดี่ยว
        var User = new LabUserViewModel();
        User.UserID = "A";
        User.Name = "AAA";
        User.Lastname = "BBB";
        // User.Address = "7001 ตำบลไก่ดำ";
        User.Weight = 60;
        User.Height = 180 ;
        User.Age = 20;


        // แบบ list
        // var User = new List<LabUserViewModel>
        // {
        //     new LabUserViewModel
        //     {
        //         UserID = "A",
        //         Name = "AAA",
        //         Lastname = "BBB",
        //         Weight = 70,
        //         Height = 195,
        //         Age = 35
        //     },

        //     new LabUserViewModel
        //     {
        //         UserID = "B",
        //         Name = "AA",
        //         Lastname = "CCC",
        //         Weight = 76,
        //         Height = 170,
        //         Age = 45
        //     },

        //      new LabUserViewModel
        //     {
        //         UserID = "C",
        //         Name = "dddd",
        //         Lastname = "CC",
        //         Weight = 56,
        //         Height = 180,
        //         Age = 21
        //     },
        // };
        
        return View();
    }

    public IActionResult Lab5(LabUserViewModel data)
    {
        string a,b,c;
        a = data.UserID;
        b = data.Name;
        c = data.Lastname;
        // d = data.Weight;
        // e = data.Height;
        // f = data.Age;
        ViewBag.UserID = a;
        ViewBag.Name = b;
        ViewBag.Lastname = c;
        // ViewBag.Weight = d;
        // ViewBag.Height = e;
        // ViewBag.Age= f;

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
