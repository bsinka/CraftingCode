using System;

namespace Payment
{
	//internal class PaymentService : IPaymentService
	//{
	//	private IPaymentGateway paymentGateway;
	//	private IUserService userService;

	//	public PaymentService(IUserService userService, IPaymentGateway paymentGateway)
	//	{
	//		this.userService = userService;
	//		this.paymentGateway = paymentGateway;
	//	}

	//	void IPaymentService.ProcessPayment(IUser invalidUser, IPaymentDetails paymentDetails)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}
	public class PaymentService
	{
		private readonly IPaymentGateway _paymentGateway;
		private readonly IUserValidator _userValidator;

		public PaymentService(IPaymentGateway paymentGateway, IUserValidator userValidator)
		{
			_paymentGateway = paymentGateway;
			_userValidator = userValidator;
		}

		public void Process(User user, PaymentDetails paymentDetails)
		{
			if (!_userValidator.IsValid(user))
				throw new InvalidOperationException("User is not valid");

			_paymentGateway.Process(paymentDetails);
		}
	}
}