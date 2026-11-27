namespace c_sharp_challenges._24_11_2026;

public enum TransactionType
{
    Deposit,
    Withdrawal
}

public static class TransactionValidator
{
    public static bool Validate(
        TransactionType type,
        decimal amount,
        decimal balance)
    {
        if (amount <= 0) return false;

        if (balance < 0) return false;
        
        if (type == TransactionType.Deposit)
        {
            balance += amount;
            return true;
        }
        if (type == TransactionType.Withdrawal)
        {
            if (amount > balance)
            {
                return false;
            }

            balance -= amount;
            return true;
        }

        return false;
    }
}

/*1. A transaction amount must be greater than zero.
2. A deposit is valid when its amount is positive.
3. A withdrawal is valid only when its amount is positive and does not exceed the current balance.
4. A negative balance must make every transaction invalid.
5. An unsupported transaction type must return `false`.*/