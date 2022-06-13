using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MindHealth.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AspNetUsers")]
        public string idUser { get; set; }
        [ForeignKey("AspNetUsers")]
        public string idTherapist { get; set; }
        public string message { get; set; }
        public IdentityUser IdentityUser { get; set; }

        public IdentityUser Therapist{ get; set; }
    }
}
