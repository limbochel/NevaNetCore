using Microsoft.AspNetCore.Mvc;
using NevaNetCore.Models;
using System.Diagnostics;
using NevaNetCore;
using System.Text.Json;
using System;
using Neva.Drivers.Fptr;

namespace NevaNetCore.Controllers
{
    public class HomeController : Controller
    {
        ConnectionSettings connection = new ConnectionSettings();
        IFptr fptr = new Fptr();
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
             //C:\Program Files\NevaDriver
            _logger = logger;
            //IFptr fptr = new Fptr(getApplicationContext());
        }
        [HttpGet]
        public IActionResult Index()
        {
            IFptr fptr = new Fptr(); //C:\Program Files\NevaDriver
            int p = 10;
            connection.Version_driver = fptr.version();
            return View(connection);

        }
        [HttpPost]
        public IActionResult Index(ConnectionSettings model)
        {
            fptr.setSettings(JsonSerializer.Serialize(connection));
            if (fptr.printText() < 0)
            {
                connection.Connection_status = fptr.errorCode().ToString();
                connection.Version_driver = "dasd";
            }
            return View(connection);
        }
        public IActionResult CONNECT()
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