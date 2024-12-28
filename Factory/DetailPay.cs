using System.ComponentModel.DataAnnotations;
namespace Factory
{
    public class DetailPay
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]      
        public decimal Value {  get; set; }

        public int MethodPaymentId { get; set; }
        public MethodPayment MethodPayment {  get; set; }
        
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } 
        
    }
}
