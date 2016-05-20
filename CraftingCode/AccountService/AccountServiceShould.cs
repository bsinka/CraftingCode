using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AccountService
{
	public class AccountServiceShould
	{
		private AccountService _accountService;
		private Mock<IConsole> _console;
		private Mock<IDateController> _dateController;

		public AccountServiceShould()
		{
			_console = new Mock<IConsole>();
			_console.Setup(c => c.Content).Returns("DATE | AMOUNT | BALANCE" + Environment.NewLine);
			_accountService = new AccountService(_console.Object, _dateController.Object);
		}

		[Fact]
		public void PrintStatementOnEmptyAccount()
		{
			_accountService.printStatement();
			Assert.Equal(_console.Object.Content, "DATE | AMOUNT | BALANCE" + Environment.NewLine);
		}

		//[Fact]
		public void AddDeposit()
		{
			_console.Setup(c => c.Content).Returns("DATE | AMOUNT | BALANCE" + Environment.NewLine);
			_accountService.deposit(100);
			_accountService.printStatement();
			//Assert.
		}
	}
}
