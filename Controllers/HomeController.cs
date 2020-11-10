using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _FORMULARIO_PRG.Models;

namespace _FORMULARIO_PRG.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Producto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Producto(string nombre, double precio, string descripcion)
        {
            //TODO: Hacer algo con los parametros nombre, precio y descripcion
            return RedirectToAction("ProductoConfirmacion");
        }

        public IActionResult ProductoConfirmacion()
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
