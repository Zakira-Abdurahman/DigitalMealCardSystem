using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Application.Interfaces.Services.TransactionManagement
{
    public interface ITransactionService
    {
        Transaction GetTransaction(int id);
        IEnumerable<Transaction> GetTransactions();
        void CreateTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }

}
