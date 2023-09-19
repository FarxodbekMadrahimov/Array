using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Dtos
{
    public class PaymentsDto
    {
        public double SenderCardNumber { get; set; }
        public double RecipientCardNumber { get; set; }
        public double Amout { get; set; }
    }
}
