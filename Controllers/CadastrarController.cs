using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PizzaEverisDay.Models;


namespace PizzaEverisDay.Controllers
{
    public class CadastrarController : Controller
    {

        [HttpGet]
        public IActionResult Cadastro()
        {        
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, string dataNascimento, string telefone, string cpf)
        {
            Cliente cliente = new Cliente(nome, dataNascimento, telefone, cpf);
            using(var repo = new PizzaContext())
            {
                repo.Add(cliente);
                repo.SaveChanges(); //devolve um int de quantas linhas foram alteradas
            }           
            return View("../Cadastrar/Cadastro"); 
        }        
    }
}    
