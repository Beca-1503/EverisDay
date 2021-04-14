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
        public ActionResult Cadastro(string nome, string data_Nascimento, string telefone, string cpf)
        {
            Cliente cliente = new Cliente(nome, data_Nascimento, telefone, cpf);
            using(var repo = new PizzaContext())
            {
                repo.Cliente.Add(cliente);
                repo.SaveChanges(); //devolve um int de quantas linhas foram alteradas
            }           
            return View("../Cadastrar/Cadastro"); 
        }        
    }
}    
