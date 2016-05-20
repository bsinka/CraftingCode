namespace Payment
{
	public interface IPaymentGateway
	{
		void Process(PaymentDetails paymentDetails);
	}
}