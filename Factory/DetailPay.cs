using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class DetailPay
    {
      public int Id { get; set; } 

        public string Name { get; set; } 
      public decimal   Value {  get; set; }

        public int MethodPaymentId { get; set; }
        public MethodPayment MethodPayment {  get; set; }
        

        public int PaymentId { get; set; }
        public Payment Payment { get; set; } 
        
    }
}
