using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaEverisDay.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<pedido> Pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD
            optionsBuilder.UseSqlServer(@"Data Source=UDI-CL0DM83\SQLEXPRESS;Database=Pizza;User ID=sa;Password=root@2020;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
=======
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HSEEB7N;Initial Catalog=Pizza;Integrated Security=True");
>>>>>>> Layout2
        }
    }
}