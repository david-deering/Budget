
namespace Domain
{
    public interface IServiceFactory
    {

        IAccountService CreateAccountService();

        IPayDayService CreatePayDayService();

    }
}