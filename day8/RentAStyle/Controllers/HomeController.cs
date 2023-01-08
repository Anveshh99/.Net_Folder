using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentAStyle.Models;
using Shop;
using DataAccessLayer;
using bussinesslayer;

namespace RentAStyle.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CustomerBussinessLayer cbl= new CustomerBussinessLayer();
        List<Customer> list= cbl.getData();
        return View();       
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }

    public IActionResult RegistrationSuccess(int cid,string name,string email,string password)
    {
        CustomerBussinessLayer cbl=new CustomerBussinessLayer();
        cbl.InsertData(cid,name,email,password);
        cbl.storedetail();
        return View();
    }

     public IActionResult Validate(string email,string password)
    {
        CustomerBussinessLayer cbl=new CustomerBussinessLayer();
         if(cbl.validate(email,password)){
            Console.WriteLine("in if");
            return Redirect("/home/index");
         }
          return View() ; 
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult CustomerDisplay()
    {
        CustomerBussinessLayer cbl=new CustomerBussinessLayer();
        List<Customer> cust=cbl.getData();
        ViewData["ListofCustomer"]=cust;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
