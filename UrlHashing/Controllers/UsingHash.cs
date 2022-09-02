using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlHashing.Controllers
{
    public class UsingHash : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
