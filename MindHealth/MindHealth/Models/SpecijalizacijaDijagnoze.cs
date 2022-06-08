using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class SpecijalizacijaDijagnoze
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Korisnik")]
        public int idKorisnika { get; set; }

        public Korisnik Korisnik { get; set; }


        public SpecijalizacijaDijagnoze() { }

    }
}
