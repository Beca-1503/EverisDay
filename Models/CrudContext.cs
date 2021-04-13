using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class CrudContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HSEEB7N;Initial Catalog=Crud;Integrated Security=True");
        }
    }
}
