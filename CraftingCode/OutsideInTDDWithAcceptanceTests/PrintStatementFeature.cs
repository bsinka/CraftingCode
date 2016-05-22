using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace AccountService
{
	//Acceptance test
	public class PrintStatementFeature
	{
      private TransactionRepository transactionRepository;

      public PrintStatementFeature()
      {
         transactionRepository = new TransactionRepository();
      }

      [Fact]
		public void print_statement_containing_transactions_in_reverse_chronological_order()
		{
			AccountService accountService = new AccountService(transactionRepository);
			accountService.Deposit(1000);
         accountService.Withdraw(100);
			accountService.Deposit(500);

			accountService.PrintStatement();

			string expectedResulut =
				"DATE | AMOUNT | BALANCE" + Environment.NewLine +
				"10/04/2014 | 500.00 | 1400.00" + Environment.NewLine +
				"02/04/2014 | -100.00 | 900.00" + Environment.NewLine +
				"01/04/2014 | 1000.00 | 1000.00";

			//Assert.Equal(expectedResulut, _console.Content);
		}
	}
}