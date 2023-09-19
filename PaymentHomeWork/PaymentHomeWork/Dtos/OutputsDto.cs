using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Dtos
{
    public class OutputsDto
    {
        public double CardNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
