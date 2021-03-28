using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcApp.Models;

namespace MvcApp.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    public static List<Role> roleInSystem = new List<Role>()
    {
      new Role { Id = 0, Name = "Admin" },
      new Role { Id = 1, Name = "Visitor" }
    };
    public static List<User> userList = new List<User>
      {
        new User { Id = 0, Username = "admin", Password = "123" },
        new User { Id = 1, Username = "notAdmin", Password = "1" }
      };
    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
