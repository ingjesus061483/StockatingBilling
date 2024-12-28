using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Factory
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public decimal SubTotal
        { 
            get 
            {
                return BillHeader.Total;
            }
        }

        [NotMapped]
        public  List<Tax > Taxes { get; set; }

        decimal _TotalTax;      
        public decimal Tax 
        { 
            get 
            {
                if (Company.RegimenTypeId  == 2)
                {
                    _TotalTax = 0;
                    foreach (Tax  item in Taxes )
                    {
                        decimal calculo = (SubTotal * item.Value ) / 100;
                        _TotalTax += calculo;
                    }
                }
                return _TotalTax;
            }
        }

        [NotMapped]        
        public Company Company { get; set; }

        [Required]
        public decimal Discount { get; set; }

        [Required]
        public decimal TotalPay 
        { 
            get 
            {
                return  SubTotal+Tax-Discount;
            }
        }        

        [Required]
        decimal _valueReceived;
        public decimal ValueReceived
        {
            get
            {
                _valueReceived = 0;

                foreach (DetailPay item in DetailPays) 
                {
                    _valueReceived += item.Value;
                }
                return _valueReceived;
            }
        }

        [Required]
        public decimal Change
        {
            get
            {
                return ValueReceived - TotalPay;
            }
        }

        [Required]
        public int BillHeaderId { get; set; }
        public BillHeader BillHeader {get; set;}

        List<DetailPay> DetailPays { get; set; }
    }
}
