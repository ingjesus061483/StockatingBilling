using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class PictureProduct
    {
        public int Id { get; set; }

        [Required]
        public int PictureID {  get; set; }
        public Picture  Picture { get; set; }

        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
