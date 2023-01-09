using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAStyle.Models;

using BBL;
using BOL;

namespace RentAStyle.Controllers;

public class MedicineController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public MedicineController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        BrandCatalog manager=new BrandCatalog();
        List<Medicine> allProducts=manager.GetAllProducts();
        this.ViewData["medicine"]=allProducts;
        return View();
    }

   
}
