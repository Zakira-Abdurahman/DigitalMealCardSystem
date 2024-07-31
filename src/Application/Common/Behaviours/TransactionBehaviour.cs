using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DigitalMealCardSystem.Application.Common.Behaviours;
public interface ITransactionBehaviour
{
    void CheckMealRestrictions(Transaction transaction);
}

public class TransactionBehaviour : ITransactionBehaviour
{
    public void CheckMealRestrictions(Transaction transaction)
    {
        // implementation
    }
}
