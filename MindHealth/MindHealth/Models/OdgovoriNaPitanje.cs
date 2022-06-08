using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class OdgovoriNaPitanje
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Dijagnoza")]
        public int dijagnozaID { get; set; }
        public Dijagnoza Dijagnoza { get; set; }


        public OdgovoriNaPitanje() { }

    }
}
