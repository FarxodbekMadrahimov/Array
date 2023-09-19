using System.ComponentModel.DataAnnotations;

namespace PaymentHomeWork.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public double defaultCard { get; set; }
        public double Cashback { get;set; }
    }
}