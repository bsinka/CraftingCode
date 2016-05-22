namespace AccountService
{
   public class AccountService
	{
      private TransactionRepository transactionRepository;

      public AccountService(TransactionRepository transactionRepository)
      {
         this.transactionRepository = transactionRepository;
      }

      public void Deposit(int amount)
		{
         transactionRepository.AddDepisit(amount);
		}

		public void Withdraw(int amount)
		{
         transactionRepository.AddWidrowal(amount);
		}

		public void PrintStatement()
		{

		}
	}
}
