using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
  public class MemberController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Details()
    {
      var member = new Member()
      {
        FirstName = "Loc",
        LastName = "Nguyen",
        Gender = "Male",
        DateOfBirth = new DateTime(1997, 1, 10),
        PhoneNumber = "123456789",
        BirthPlace = "Hanoi",
        IsGraduated = true,
        StartDate = new DateTime(2015, 1, 20),
        EndDate = new DateTime(2018, 6, 20)
      };

      return View(member);
    }
    
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Member member)
    {
      if (ModelState.IsValid)
      {
        return RedirectToAction("Index");
      }
      return View(member);
    }

    public IActionResult Login()
    {
      return View();
    }
  }
}
