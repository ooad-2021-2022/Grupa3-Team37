using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class Odgovor
    {
        [Key]
        public int Id { get; set; }
        public string odgovor { get; set; }

        [ForeignKey("OdgovoriNaPitanje")]
        public int odgovoriNaPitanjeID { get; set; }
        
        public OdgovoriNaPitanje OdgovoriNaPitanje { get; set; }



        public Odgovor() { }

    }
}
