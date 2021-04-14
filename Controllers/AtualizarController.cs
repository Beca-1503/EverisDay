using Microsoft.AspNetCore.Mvc;
using PizzaEverisDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Controllers
{
    public class AtualizarController : Controller
    {
        public IActionResult Atualizar()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Atualizar(string cpf, string nome, string telefone, string dataNascimento)
        {
            using (var repo = new PizzaContext())
            {
                var data = repo.Cliente.FirstOrDefault(x => x.CPF == cpf);
                data.Nome = nome;
                data.Data_Nascimento = dataNascimento;
                data.Telefone = telefone;
                repo.SaveChanges();
            }
            return View("Atualizar");
        }
    }
}
