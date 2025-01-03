﻿using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class Stock
    {
        public int Id {  get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public bool Entrance { get; set; }

        [Required]
        public int WarehouseId {  get; set; }
        public Warehouse Warehouse {  get; set; }

        [Required]
        public int ProductId {  get; set; }
        public Product Product { get; set; }   
    }
}
