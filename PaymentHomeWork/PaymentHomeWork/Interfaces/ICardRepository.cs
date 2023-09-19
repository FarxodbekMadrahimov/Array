using PaymentHomeWork.Dtos;
using PaymentHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Interfaces
{
    public interface ICardRepository
    {
        void CreateCard(CardDto card);
        void DeleteCard(int CardId);
        List<Card> GetAllCardsUser(int UserId);
        void UpdateCard(int CardId, CardDto card);
    }
}
