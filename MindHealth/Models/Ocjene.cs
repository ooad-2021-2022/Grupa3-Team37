using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Ocjene
    {
        [Key]
        public int ID { get; set; }

        public int ocjena { get; set; }

        [ForeignKey("Korisnik")]
        public int idKorisnika { get; set; }
        public Korisnik Korisnik { get; set; }
        
        public Ocjene() { }

    }
}
