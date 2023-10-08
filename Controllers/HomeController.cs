using Microsoft.AspNetCore.Mvc;
using NevaNetCore.Models;
using System.Diagnostics;
using NevaNetCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using Neva.Drivers.Fptr;
using System.Xml.Serialization;

namespace NevaNetCore.Controllers
{
    public class HomeController : Controller
    {
        public ConnectionSettings connection = new ConnectionSettings();
        

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
           
            
            

            return View(connection);
        }
        [HttpPost]
        public IActionResult Index(ConnectionSettings model)
        {
            string test = model.LIBFPTR_SETTING_MODEL;
            IFptr fptr = new Fptr(@"C:\Program Files\NevaDriver");
            String dfd = fptr.getDeviceList();
            String ipPort = fptr.getSingleSetting(Constants.LIBFPTR_SETTING_COM_FILE);
            fptr.setSingleSetting(Constants.LIBFPTR_SETTING_PORT, model.LIBFPTR_SETTING_PORT);
            fptr.setSingleSetting(Constants.LIBFPTR_SETTING_COM_FILE, model.LIBFPTR_SETTING_COM_FILE);
            fptr.setSingleSetting(Constants.LIBFPTR_SETTING_IPADDRESS, model.LIBFPTR_SETTING_IPADDRESS);
            fptr.setSingleSetting(Constants.LIBFPTR_SETTING_IPPORT, model.LIBFPTR_SETTING_IPPORT);
            fptr.applySingleSettings();
            connection.Version_driver = fptr.version();
            fptr.open();
            if(fptr.isOpened() == 1)
            {
                connection.Connection_status = "подключение успешно";
            }
            else
            {
                connection.Connection_status = "подключение не успешно";
            }
            int isOpened = fptr.isOpened();
            fptr.setParamStr(Constants.LIBFPTR_PARAM_REPORT_TYPE, Constants.LIBFPTR_RT_KKT_INFO.ToString());
            fptr.report();
            fptr.close();
            fptr.destroy();
            return View(connection);

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