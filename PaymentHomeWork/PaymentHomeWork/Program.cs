using PaymentHomeWork.DataContexts;
using PaymentHomeWork.Dtos;
using PaymentHomeWork.Services;

namespace PaymentHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User();
        }
        public static void User()
        {
            DataContext context = new DataContext();

            //UserRepository userRepository = new UserRepository(context);

            CardRepository cardRepository = new CardRepository(context);

            cardRepository.CreateCard(new CardDto()
            {
                CardNumber = 8600060941687130,
                UserId = 1,
                Amout = 50_000,
                ExpirationDate = "2006/10/08"
            });


        }
    }
}