using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Domain.Entities
{
    public class Transaction
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public int MealId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime TransactionDate { get; private set; }

        public Transaction(int id, int studentId, int mealId, decimal amount, DateTime transactionDate)
        {
            Id = id;
            StudentId = studentId;
            MealId = mealId;
            Amount = amount;
            TransactionDate = transactionDate;
        }
    }
}
