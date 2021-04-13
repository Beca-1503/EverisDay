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
        public ActionResult Deletar(string IdPessoa)
        {
            using(var repo = new PizzaContext())
            {
               /* repo.Cliente.Where(x => x.Id == "2").ToList(); 
                repo.Cliente.Remove(new Cliente() {
                    //Nome = "Gabriel",
                    //Sobrenome = "Benedet",
                    Id = IdPessoa
                });;
                repo.SaveChanges();
                
                */
                return Content("Deletado do banco");
            }
        }
    }
}
