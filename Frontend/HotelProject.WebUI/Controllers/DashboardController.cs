using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
    }
}