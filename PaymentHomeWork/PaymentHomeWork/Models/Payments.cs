using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Models
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        public double SenderCardNumber { get; set; }
        public double RecipientCardNumber { get; set; }
        public double Amout { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
