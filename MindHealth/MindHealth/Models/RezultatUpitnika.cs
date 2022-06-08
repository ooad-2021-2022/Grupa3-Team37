using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindHealth.Models
{
    public class RezultatUpitnika
    {
        [Key]
        public int Id { get; set; }
        public double postotak { get; set; }
        
        [ForeignKey("Upitnik")]
        public int upitnikId { get; set; }

        public Upitnik Upitnik { get; set; }

 

        public RezultatUpitnika() { }


    }
}
