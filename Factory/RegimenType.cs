﻿using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class RegimenType
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public List <Company> Companies { get; set; }

    }
}
