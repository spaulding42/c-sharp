﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login_Registration.Models;

namespace Login_Registration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/success")]
    public IActionResult Success()
    {
        if (HttpContext.Session.GetInt32("UUID") == null) 
        {
            return RedirectToAction("Index", "Users");
        }
        return View("Success");
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
