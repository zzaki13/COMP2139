using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using COMP2139Lab1.Models;

namespace COMP2139Lab1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewBag.StudentName = "Zaki Mohammed";
        ViewBag.StudentNumber = "101507934";
        ViewBag.CourseCode = "COMP2139";
        ViewBag.CourseSection = "CRN: 50262";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}