using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Upitnik
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Korisnik")]
        public int idKorisnika { get; set; }
        public Korisnik Korisnik { get; set; }

        public Upitnik() { }

    }
}
