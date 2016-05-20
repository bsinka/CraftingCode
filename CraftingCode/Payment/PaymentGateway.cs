using System;

namespace Payment
{
	public class PaymentGateway : IPaymentGateway
	{
		public void Process(PaymentDetails paymentDetails)
		{
			throw new NotImplementedException();
		}
	}
}