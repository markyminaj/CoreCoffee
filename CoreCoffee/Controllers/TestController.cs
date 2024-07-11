using CoreCoffee.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCoffee.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        var data = new TestViewModel
        {
            Name = "Student",
            DateOfBirth = new DateTime(2024, 07, 10)
        };
        return View(data);
    }
}

