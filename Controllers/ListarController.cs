using Microsoft.AspNetCore.Mvc;
using PizzaEverisDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Controllers
{
    public class ListarController : Controller
    {
        //public IActionResult Listar()        //{

        //}

        [HttpGet]
        public ActionResult Listar()
        {
            using (var repo = new PizzaContext())
            {
                var data = repo.Cliente.ToList();
                return View(data);
            }            
        }
    }
}
