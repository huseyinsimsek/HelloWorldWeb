using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldWeb.Controllers
{
    public class CetController : Controller
    {
        // GET: /Cet/Hello
        public IActionResult Hello()
        {
            return Content("Hello Cet");
        }
    }
}
