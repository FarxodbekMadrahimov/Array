using PaymentHomeWork.Models;

namespace PaymentHomeWork.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public double defaultCard { get; set; }
        public double Cashback { get; set; }
    }
}
