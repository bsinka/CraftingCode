namespace Payment
{
	public interface IUserValidator
	{
		bool IsValid(User user);
	}
}