using PaymentHomeWork.DataContexts;
using PaymentHomeWork.Dtos;
using PaymentHomeWork.Interfaces;
using PaymentHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Services
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DataContext context;

        public PaymentRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task SendMoney(PaymentsDto payments)
        {
            Payments newPayments = new Payments();

            newPayments.SenderCardNumber = payments.SenderCardNumber;
            newPayments.RecipientCardNumber = payments.RecipientCardNumber;
            newPayments.Amout = payments.Amout;

            await context.Payments.AddAsync(newPayments);
            await context.SaveChangesAsync();
        }
    }
}
