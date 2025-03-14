using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didital_Banking.Models
{
    public class Compte
    {
        [Key]
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Type { get; set; } // "courant" ou "epargne"
        public decimal Solde { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ICollection<Transaction> TransactionsSource { get; set; }
        public ICollection<Transaction> TransactionsDest { get; set; }
    }
}
