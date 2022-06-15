using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class OdgovoriNaPitanje
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Upitnik")]
        public int upitnikID { get; set; }
        public Upitnik Upitnik { get; set; }
        public int odgovoreno { get; set; }
        public string tekstPitanja { get; set; }


        public OdgovoriNaPitanje() { }

    }
}
