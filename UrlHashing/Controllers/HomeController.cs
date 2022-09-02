using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace UrlHashing.Controllers
{
    public class HomeController : Controller
    {

        [Route("SetPassword/{unhashedKey}")]
        public IActionResult SetPassword(string unhashedKey)
        {
            // Create password
            // Start to work business logic ...
            return RedirectToAction("CreatePassword"); 
        }
        [Route("CreatePassword")]
        public IActionResult CreatePassword()
        {
            return Content($"Hi, your  password created successfully. You can Sign In ...");




        }

        
        public IActionResult Index()
        {
            return View();
        }

        [NonAction]
        public void UsingBCrypt()
        {
            // → Unhashed string like [oruchankural@gmail.com] Hashed Version of it like that [$2a$11$Tnc7TooZtyqMUnbGzyWT7.o0wGgqwH3jdPoh7XYcNHGCoXFYv7rvu]
            BCrypt.Net.BCrypt.Verify("UnhashedString [input from User or anything...] ", "Hashed data");

            // → Hashing password or any string
            BCrypt.Net.BCrypt.HashPassword("inputValue");
            BCrypt.Net.BCrypt.HashString("inputValue");

            
        }

    }
}
