using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaEverisDay.Models;

namespace PizzaEverisDay.Controllers
{
    public class DeletarController : Controller
    {
        public IActionResult Deletar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deletar(string cpfCliente)
        {
            using(var repo = new PizzaContext())
            {
                                
                repo.Remove(new Cliente ()
                {                   
                    CPF = cpfCliente
                });
                repo.SaveChanges();

                return View("Deletar");
            }
        }
    }
}
