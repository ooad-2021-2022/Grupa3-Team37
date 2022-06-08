using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string imeIPrezime { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string slikaOsobe { get; set; }
        public double prosjecnaOcjena { get; set; }
        public DateTime vrijemeNarednogTermina { get; set; }
        public string skolovanje { get; set; }

        public string slika { get; set; }
        public string prethodnoIskustvo { get; set; }
        public DateTime pocetakRadnogVremena { get; set; }
        public DateTime krajRadnogVremena { get; set; }
        public DateTime datumRegistracije { get; set; }
        public DostupniJezici preferiraniJezik { get; set; }
        public OpcijePlacanja preferiraniNacinUplate { get; set; }


        public Korisnik()
        { }

    }
    
}
