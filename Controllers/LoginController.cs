using System;
using System.Linq;
using MvcApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
  public class LoginController : Controller
  {
    public static string CURRENT_LOGIN_USERNAME_KEY = "_sessionLoginUsername";
    public static string CURRENT_LOGIN_USERROLE_KEY = "_sessionLoginUserRole";

    [HttpGet]
    public IActionResult Login()
    {
      if (IsCurrentlyLoggedIn())
      {
        return RedirectToAction("Index", "Home");
      }

      return View();
    }

    [HttpPost]
    public IActionResult Login(User user)
    {
      if (ModelState.IsValid)
      {
        var searchResult =
          HomeController.userList
          .Where(s => s.Username == user.Username && s.Password == user.Password);

        bool success = searchResult.Count() == 1;
        if (success)
        {
          var loggedInUser = searchResult.First();

          var roleSearchResult =
            HomeController.roleInSystem
            .Where(s => s.Id == loggedInUser.Id)
            .FirstOrDefault();

          HttpContext.Session.SetString(
            CURRENT_LOGIN_USERNAME_KEY,
            loggedInUser.Username
          );
          HttpContext.Session.SetString(
            CURRENT_LOGIN_USERROLE_KEY,
            roleSearchResult.Name
          );
          return RedirectToAction("Index", "Home");
        }
      }
      return View(user);
    }

    [HttpPost]
    public IActionResult Logout()
    {
      HttpContext.Session.Clear();
      return RedirectToAction("Index", "Home");
    }

    private bool IsCurrentlyLoggedIn()
    {
      return HttpContext.Session.Get(CURRENT_LOGIN_USERNAME_KEY) != null;
    }
  }
}