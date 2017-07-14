using Domain;

namespace Test.Mock
{
    public class MockServiceFactory : NullServiceFactory
    {

        public override IBillService CreateBillService(string databaseId, string sessionid)
        {
            return new MockBillService();
        }

        public override IAccountService CreateAccountService()
        {
            return new MockAccountService();
        }
    }
}
