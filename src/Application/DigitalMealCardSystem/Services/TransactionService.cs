using global::DigitalMealCardSystem.Application.Common.Interfaces.IRepository;
using global::DigitalMealCardSystem.Application.Common.Interfaces.IService;

namespace DigitalMealCardSystem.Application.DigitalMealCardSystem.Services;




public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
    {
        // implementation
    }

    public async Task<Transaction> UpdateTransactionAsync(Transaction transaction)
    {
        // implementation
    }

    public async Task DeleteTransactionAsync(int transactionId)
    {
        // implementation
    }
}
