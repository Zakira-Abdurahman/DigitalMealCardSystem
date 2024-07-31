using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.PaymentProcessing
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment GetPayment(int id)
        {
            return _paymentRepository.Get(id);
        }

        public IEnumerable<Payment> GetPayments()
        {
            return _paymentRepository.GetAll();
        }

        public void CreatePayment(Payment payment)
        {
            _paymentRepository.Add(payment);
        }

        public void UpdatePayment(Payment payment)
        {
            _paymentRepository.Update(payment);
        }

        public void DeletePayment(int id)
        {
            _paymentRepository.Delete(id);
        }

    }
}