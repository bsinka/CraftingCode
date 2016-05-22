using Moq;
using Xunit;

namespace AccountService
{
   public class AccountServiceShould
	{
      private Mock<TransactionRepository> transactionRepository;
      private AccountService accountService;

		public AccountServiceShould()
		{
         transactionRepository = new Mock<TransactionRepository>();
         accountService = new AccountService(transactionRepository.Object);
		}

		[Fact]
		public void StoreDepositTransaction()
		{
         int amount = 100;
         accountService.Deposit(amount);
			transactionRepository.Verify(t => t.AddDepisit(amount), Times.Once);
		}

		[Fact]
		public void StoreWidrowalTransaction()
		{
         int amount = 100;
         accountService.Withdraw(amount);
         transactionRepository.Verify(t => t.AddWidrowal(amount), Times.Once);
      }
	}
}
