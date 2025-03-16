using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didital_Banking.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; } // "depot", "retrait", "virement"
        public decimal Montant { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("CompteSource")]
        public int? CompteSourceId { get; set; }
        [ForeignKey("CompteDest")]
        public int? CompteDestId { get; set; }
        public Compte CompteSource { get; set; }  
        public Compte CompteDest { get; set; }
    }
}
