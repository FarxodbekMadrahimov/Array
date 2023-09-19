using Microsoft.EntityFrameworkCore;
using PaymentHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.DataContexts
{
    public class DataContext : DbContext
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=ing0077K;Database=Payments;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(connectionString);
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Inputs> Inputs { get; set; }
        public DbSet<OutPuts> Outputs { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
