using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CadastrarController : Controller
    {
        public string nome { get; set; }
        public IList<string> lista { get; set; }
        
        [HttpGet]
        public IActionResult Cadastro()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(string Nome, string Sobrenome, string Id)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = Nome;
            p1.Sobrenome = Sobrenome;
            p1.Id = Id;
            using(var repo = new CrudContext())
            {
                repo.Add(p1);
                repo.SaveChanges(); //devovle um int de quantas linhas foram alteradas
            }
            
            return View("../Home/Index"); 
        }
        
    }

}    


