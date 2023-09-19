using Microsoft.EntityFrameworkCore;
using PaymentHomeWork.DataContexts;
using PaymentHomeWork.Dtos;
using PaymentHomeWork.Interfaces;
using PaymentHomeWork.Models;

namespace PaymentHomeWork.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }

        public void CreateUser(UserDto userDto)
        {
            User user = new User();

            user.UserName = userDto.UserName;
            user.firstName = userDto.firstName;
            user.lastName = userDto.lastName;
            user.phoneNumber = userDto.phoneNumber;
            user.defaultCard = userDto.defaultCard;
            user.Cashback = userDto.Cashback;

            context.Users.Add(user);
            context.SaveChanges();
        }

        public async Task DeleteUser(int UserId)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);

            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
        }

        public Card GetUserById(int UserId)
        {
            var card = context.Cards.FirstOrDefault(x => x.UserId == UserId);

            return card;
        }

        public async Task UpdateUser(int UserId, UserDto userDto)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);

            if (user != null)
            {
                user.UserName = userDto.UserName;
                user.firstName = userDto.firstName;
                user.lastName = userDto.lastName;
                user.phoneNumber = userDto.phoneNumber;
                user.defaultCard = userDto.defaultCard;
                user.Cashback = userDto.Cashback;
            }
        }
    }
}