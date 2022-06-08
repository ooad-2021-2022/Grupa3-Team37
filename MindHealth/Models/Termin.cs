using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Termin
    {
        [Key]
        public int idTermina { get; set; }
        public double cijenaTermina { get; set; }
        public string usernameKorisnika { get; set; }
        public string usernamePsihoterapeuta { get; set; }
        public string opisTermina { get; set; }

        [ForeignKey("Korisnik")]
        public int idKorisnika { get; set; }
        public DateTime vrijemeOdrzavanja { get; set; }
        public Korisnik Korisnik { get; set; }


        public Termin() { }

    }
}
