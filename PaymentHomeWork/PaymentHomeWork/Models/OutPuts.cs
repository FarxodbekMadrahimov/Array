using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Models
{
    public class OutPuts
    {
        [Key]
        public int OutOutId { get; set; }
        public double CardNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
