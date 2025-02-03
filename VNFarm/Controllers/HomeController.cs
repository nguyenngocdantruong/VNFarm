using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VNFarm.Infrastructure.Context;

namespace VNFarm.Web.VNFarm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly EcommerceContext _context;

    public HomeController(ILogger<HomeController> logger, EcommerceContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
