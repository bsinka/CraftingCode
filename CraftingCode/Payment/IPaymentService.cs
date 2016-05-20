namespace Payment
{
	internal interface IPaymentService
	{
		void ProcessPayment(IUser invalidUser, IPaymentDetails paymentDetails);
	}
}