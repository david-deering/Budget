using Domain;

namespace Test.Mock
{
    public class MockServiceFactory : NullServiceFactory
    {

        public override IAccountService CreateAccountService()
        {
            return MockAccountService.Singleton;
        }

        public override IPayDayService CreatePayDayService()
        {
            return MockPayDayService.Singleton;
        }
    }
}
