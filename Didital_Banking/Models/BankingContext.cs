using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace Didital_Banking.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BankingContext : DbContext
    {
        public BankingContext() : base("BankingContext") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
