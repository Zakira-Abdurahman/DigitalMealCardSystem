using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.PaymentProcessing
{
    public interface IPaymentService
    {
        Payment GetPayment(int id);
        IEnumerable<Payment> GetPayments();
        void CreatePayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(int id);
    }
}
