using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using passwordgenrate.Models;
using passwordgenrate.Services;

namespace passwordgenrate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private PasswordGeneric _passwordGeneric;

    public HomeController(ILogger<HomeController> logger, PasswordGeneric passwordGeneric)
    {
        _logger = logger;
        _passwordGeneric = passwordGeneric;
    }

    [HttpGet ]
    public IActionResult Index()
    {
        PassgenratorDto pdto = new();
        
        return View( pdto);
    }
    [HttpPost]
    public IActionResult Index(PassgenratorDto pdto )
    {
   
    ViewBag.generate= _passwordGeneric.Generatepass(pdto.passwordLenght);
    PassgenratorDto pdto2 = new();
    pdto.passwordLenght = 0;
        return View(pdto2);
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