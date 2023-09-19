using PaymentHomeWork.Dtos;
using PaymentHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Interfaces
{
    public interface IUserRepository
    {
        void CreateUser(UserDto userDto);
        Task UpdateUser(int UserId, UserDto userDto);
        Task DeleteUser(int UserId);
        Card GetUserById(int UserId);
    }
}
