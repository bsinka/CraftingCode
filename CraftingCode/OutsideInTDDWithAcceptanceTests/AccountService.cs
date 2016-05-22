using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace AccountService
{
	public class AccountService
	{
		private IConsole _console;
		private List<string> log = new List<string>();
		private IDateController _dateController;

		public AccountService(IConsole _console, IDateController _dateController)
		{
			this._console = _console;
			this._dateController = _dateController;
		}

		public void deposit(int amount)
		{

		}

		public void withdraw(int amount)
		{

		}

		public void printStatement()
		{

		}
	}
}
