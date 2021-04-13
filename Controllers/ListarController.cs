using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Controllers
{
    public class ListarController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }
    }
}
