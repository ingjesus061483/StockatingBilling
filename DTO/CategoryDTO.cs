﻿using Factory;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}
