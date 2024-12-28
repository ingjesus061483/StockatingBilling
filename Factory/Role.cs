using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public  class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; } 

        public List<User> Users { get; set; }
    }
}
