using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payment
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; private set; }

        public Payment(int id, int studentId, decimal amount, DateTime paymentDate)
        {
            Id = id;
            StudentId = studentId;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }


}
