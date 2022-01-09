using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Document()
        {
            return View();
        }
        public IActionResult Job()
        {
            return View();
        }
        public IActionResult Map()
        {
            return View();
        }
            public IActionResult Emespanhol()
            {
                return View();
            }
        public IActionResult Duvidas()
        {
            return View();
        }
    }
    }

