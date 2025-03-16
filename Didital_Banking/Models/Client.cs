using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didital_Banking.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public DateTime DateInscription { get; set; }
        public ICollection<Compte> Comptes { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}",Nom,Prenom);
        }
    }
}
