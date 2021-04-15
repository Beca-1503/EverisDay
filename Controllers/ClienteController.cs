using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaEverisDay.Models;

namespace PizzaEverisDay.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string cpfCliente)
        {
            using (var repo = new PizzaContext())
            {
                try
                {
                    if (cpfCliente.Length != 0)
                    {
                        repo.Remove(new Cliente()
                        {
                            CPF = cpfCliente
                        });
                        repo.SaveChanges();
                    }                    

                }
                catch(Exception)
                {
                    return View("../Error/ErroCliente");
                }   
                return View("../Home/Index");
            }
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string nome, string data_Nascimento, string telefone, string cpf)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Data_Nascimento = data_Nascimento;
            cliente.Telefone = telefone;
            cliente.CPF = cpf;
            using (var repo = new PizzaContext())
            {
                repo.Add(cliente);
                repo.SaveChanges(); 
            }
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(string cpf, string nome, string telefone, string dataNascimento)
        {
            using (var repo = new PizzaContext())
            {
                var data = repo.Cliente.FirstOrDefault(x => x.CPF == cpf);
                data.Nome = nome;
                data.Data_Nascimento = dataNascimento;
                data.Telefone = telefone;
                repo.SaveChanges();
            }
            return View("../Home/Index");
        }


        [HttpGet]
        public ActionResult Read()
        {
            using (var repo = new PizzaContext())
            {
                var data = repo.Cliente.ToList();
                return View(data);
            }            
        }
    }
}

