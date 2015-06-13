using NUnit.Framework;

namespace LiskovSubstitution.Tests
{
    [TestFixture]
    public class OverdraftAccountTests : BankAccountTests {
        protected override BankAccount CreateAccountWithStartingBalance(int balance)
        {
            var accountWithStartingBalance = new OverdraftAccount(0);
            accountWithStartingBalance.Credit(balance);
            return accountWithStartingBalance;
        }

        [Test]
        public void CanDebitMoreThanAvailableBalance()
        {
            Assert.DoesNotThrow(() => new OverdraftAccount(100).Debit(50));
        }

        [Test]
        public void CannotDebitMoreThanAvailableBalancePlusOverdraftLimit()
        {
            Assert.Throws<DebitAmountExceedsLimitException>(() => new OverdraftAccount(100).Debit(150));
        }
    }
}
