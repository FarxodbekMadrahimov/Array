using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Models
{
    public class Inputs
    {
        [Key]
        public int InputId { get; set; }
        public double CardNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
