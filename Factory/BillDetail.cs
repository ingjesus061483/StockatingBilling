using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Factory
{
    public class BillDetail
    {
        public int Id { get; set; }

        public int?  WarehouseId { get; set; }
        public Warehouse? Warehouse { get; set; }

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
