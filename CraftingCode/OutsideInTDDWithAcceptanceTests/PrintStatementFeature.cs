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
		private readonly IConsole _console = (new Mock<IConsole>()).Object;
		private readonly IDateController _dateController = (new Mock<IDateController>()).Object;

		[Fact]
		public void print_statement_containing_transactions_in_reverse_chronological_order()
		{
			AccountService accountService = new AccountService(_console, _dateController);
			accountService.deposit(1000);
			accountService.withdraw(100);
			accountService.deposit(500);

			accountService.printStatement();

			string expectedResulut =
				"DATE | AMOUNT | BALANCE" + Environment.NewLine +
				"10/04/2014 | 500.00 | 1400.00" + Environment.NewLine +
				"02/04/2014 | -100.00 | 900.00" + Environment.NewLine +
				"01/04/2014 | 1000.00 | 1000.00";

			Assert.Equal(expectedResulut, _console.Content);
		}
	}
}