using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class PrethodnaTerapija
    {
        [Key]
        public int id { get; set; }
        public string koristeniLijek { get; set; }

        public DateTime datumPocetkaTerapije { get; set; }

        public DateTime datumKrajaTerapije { get; set; }

        public string nazivDijagnoze { get; set; }

        [ForeignKey("Korisnik")]
        public int idKorisnika   { get; set; }
        public Korisnik Korisnik { get; set; }


        public PrethodnaTerapija() { }


    }
}
