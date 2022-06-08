using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Pitanje
    {
        [Key]
        public int Id { get; set; }
        public string tekstPitanja { get; set; }

        [ForeignKey("Dijagnoza")]
        public int dijagnozaId { get; set; }

        public Dijagnoza Dijagnoza { get; set; }




        public Pitanje() {}
    }
}
