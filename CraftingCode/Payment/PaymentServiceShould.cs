using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace Payment
{
	//public class PaymentServiceShould
	//{
	//	private IUser invalidUser;
	//	private IPaymentDetails paymentDetails;

	//	private IPaymentGateway paymentGateway;
	//	private IPaymentService paymentService;
	//	private IUserService userService;

	//	public void Initialize()
	//	{
	//		invalidUser = (new Mock<IUser>()).Object;

	//		userService = (new Mock<IUserService>()).Object;
	//		paymentGateway = (new Mock<IPaymentGateway>()).Object;

	//		paymentService = new PaymentService(userService, paymentGateway);
	//	}

	//	[Fact]
	//	public void ThrowExceptionWhenUserIsNotValid()
	//	{
	//		Initialize();
	//		Assert.Throws<NotImplementedException>(() => paymentService.ProcessPayment(invalidUser, paymentDetails));
	//	}
	//}

	public class PaymentServiceShould
	{
		private readonly Mock<IUserValidator> _userValidatorMock;
		private readonly Mock<IPaymentGateway> _paymentGatewayMock;
		private readonly PaymentService _paymentService;

		private readonly User _user = new User();
		private readonly PaymentDetails _paymentDetails = new PaymentDetails();

		public PaymentServiceShould()
		{
			_userValidatorMock = new Mock<IUserValidator>();
			_paymentGatewayMock = new Mock<IPaymentGateway>();
			_paymentService = new PaymentService(_paymentGatewayMock.Object, _userValidatorMock.Object);
		}

		[Fact]
		public void ProcessPaymentDetails_WhenUserIsValid()
		{
			_userValidatorMock.Setup(u => u.IsValid(_user)).Returns(true);

			_paymentService.Process(_user, _paymentDetails);

			_paymentGatewayMock.Verify(d => d.Process(_paymentDetails), Times.Once);
		}

		[Fact]
		public void ThrowsInvalidOperationException_WhenUserIsInvalid()
		{
			_userValidatorMock.Setup(u => u.IsValid(_user)).Returns(false);

			Assert.Throws<InvalidOperationException>(() => _paymentService.Process(_user, _paymentDetails));
		}

		[Fact]
		public void NotInvokePaymentGateway_WhenUserIsInvalid()
		{
			_userValidatorMock.Setup(u => u.IsValid(_user)).Returns(false);

			try
			{
				_paymentService.Process(_user, _paymentDetails);
			}
			catch (InvalidOperationException)
			{
			}

			_paymentGatewayMock.Verify(d => d.Process(_paymentDetails), Times.Never);
		}
	}
}
