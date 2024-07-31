using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Application.Interfaces.Services.TransactionManagement
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Transaction GetTransaction(int id)
        {
            return _transactionRepository.Get(id);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactionRepository.GetAll();
        }

        public void CreateTransaction(Transaction transaction)
        {
            _transactionRepository.Add(transaction);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.Update(transaction);
        }

        public void DeleteTransaction(int id)
        {
            _transactionRepository.Delete(id);
        }
    }


}
