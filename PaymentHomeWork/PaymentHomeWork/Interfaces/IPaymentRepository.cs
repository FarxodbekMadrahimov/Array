using PaymentHomeWork.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentHomeWork.Interfaces
{
    public interface IPaymentRepository
    {
        Task SendMoney(PaymentsDto payments);
    }
}
