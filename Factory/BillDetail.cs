using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BillDetail
    {
        public int ID;

        [Required]
        public decimal  Amount {  get; set; }

        [Required]
        public int ProductId {  get; set; }
        public Product Product { get; set; }

        [Required]
        public decimal UnitPrice {  get; set; }

        [Required]
        public int BillHeaderId {  get; set; }
        public BillHeader BillHeader { get; set; }
        public decimal Total { get { return Amount * UnitPrice; } }

    }
}
