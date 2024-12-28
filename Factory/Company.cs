using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Factory
{
    [Index(nameof(Nit), IsUnique = true)]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nit { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string TradeCamera { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Contact { get; set; }
       
        public string? Slogan { get; set; }

        [Required]
        public int  RegimenTypeId { get; set; }
        public RegimenType RegimenType { get; set; }    

        public List <User> Users { get; set; }  
    }
}
