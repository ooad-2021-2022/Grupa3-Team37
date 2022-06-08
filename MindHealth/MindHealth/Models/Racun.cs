using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models

{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        public DateTime datumPlacanja { get; set; }
        public double iznosUplate { get; set; }

        [ForeignKey("Termin")]
        public int idTermina { get; set; }

        public Termin Termin { get; set; }


        public Racun() { }


    }
}
