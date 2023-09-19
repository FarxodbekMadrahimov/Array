using PaymentHomeWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Dtos
{
    public class CardDto
    {
        public double CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public double Amout { get; set; } = 50000;
        public int UserId { get; set; }
    }
}
