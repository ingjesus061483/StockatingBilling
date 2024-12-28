﻿using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name {  get; set; }

        public string? Description { get; set; }

        public List<Product> Products {  get; set; }    
    }
}
