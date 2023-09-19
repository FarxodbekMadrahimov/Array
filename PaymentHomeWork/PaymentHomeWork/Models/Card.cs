using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public double CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public double Amout { get; set; } = 50000;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
