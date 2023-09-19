using Microsoft.EntityFrameworkCore;
using PaymentHomeWork.DataContexts;
using PaymentHomeWork.Dtos;
using PaymentHomeWork.Interfaces;
using PaymentHomeWork.Models;

namespace PaymentHomeWork.Services
{
    public class CardRepository : ICardRepository
    {
        private readonly DataContext context;
        public CardRepository(DataContext context)
        {
            this.context = context;
        }
        public void CreateCard(CardDto card)
        {
            Card newCard = new Card();

            newCard.CardNumber = card.CardNumber;
            newCard.Amout = card.Amout;
            newCard.UserId = card.UserId;
            newCard.ExpirationDate = card.ExpirationDate;
            newCard.UserId = card.UserId;

            context.Cards.Add(newCard);
            context.SaveChanges();
        }

        public void DeleteCard(int CardId)
        {
            var card = context.Cards.FirstOrDefault(x => x.CardId == CardId);
            context.Cards.Remove(card);
            context.SaveChanges();
        }

        public List<Card> GetAllCardsUser(int UserId)
        {
            var userCards = context.Cards.AsNoTracking().ToList();

            return userCards;
        }

        public void UpdateCard(int CardId, CardDto card)
        {
            var newCard = context.Cards.FirstOrDefault(x => x.CardId == CardId);

            newCard.CardNumber = card.CardNumber;
            newCard.Amout = card.Amout;
            newCard.UserId = card.UserId;
            newCard.ExpirationDate = card.ExpirationDate;

            context.Cards.Update(newCard);
            context.SaveChanges();
        }
    }
}
