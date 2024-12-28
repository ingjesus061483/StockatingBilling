using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class Tax
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]       
        public string Name { get; set; }

        [Required]
        public decimal Value { get; set; }

        public string? Description { get; set; }
    }
}
