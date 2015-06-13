namespace LiskovSubstitution
{
    public class OverdraftAccount : BankAccount
    {
        private readonly int overdraftLimit;

        public OverdraftAccount(int overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Debit(double amount)
        {
            if (amount > balance + overdraftLimit)
                throw new DebitAmountExceedsLimitException();
            balance -= amount;
        }
    }
}
