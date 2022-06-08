using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Dijagnoza
    {
        [Key]
        public int idDijagnoze { get; set; }
        public VrstaDijagnoze vrstaDijagnoze { get; set; }

        [ForeignKey("Upitnik")]
        public int rezultatUpitnikaID { get; set; }

        public RezultatUpitnika RezultatUpitnika { get; set; }

        public Dijagnoza() { }

    }
}
