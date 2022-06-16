using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindHealth.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string slikaOsobe { get; set; }
        public double prosjecnaOcjena { get; set; }
        public DateTime vrijemeNarednogTermina { get; set; }
        public string skolovanje { get; set; }

        internal object First()
        {
            throw new NotImplementedException();
        }

        public string slika { get; set; }
        public string prethodnoIskustvo { get; set; }
        public DateTime pocetakRadnogVremena { get; set; }
        public DateTime krajRadnogVremena { get; set; }
        public DateTime datumRegistracije { get; set; }
        public DostupniJezici preferiraniJezik { get; set; }
        public OpcijePlacanja preferiraniNacinUplate { get; set; }
        public  VrstaDijagnoze specijalizacija { get; set; }
        public Korisnik()
        { }
     

    }
    
}
