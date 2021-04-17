using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuitarTabPDF.Services;

namespace GuitarTabPDF.Controllers
{
    public class HomeController : Controller
    {
        private ITabConverter tabConverter;
        public HomeController(ITabConverter tabCvtr)
        {
            tabConverter = tabCvtr;
        }
        public IActionResult Index()
        {
            string title = tabConverter.Convert("https://tabs.ultimate-guitar.com/tab/ed-sheeran/perfect-chords-1956589");
            return View((object)title);
        }
    }
}
