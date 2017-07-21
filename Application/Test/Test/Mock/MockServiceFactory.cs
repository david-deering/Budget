using Domain;

namespace Test.Mock
{
    public class MockServiceFactory : NullServiceFactory
    {

        public override IAccountService CreateAccountService()
        {
            return new MockAccountService();
        }

    }
}
