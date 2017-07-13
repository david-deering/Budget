
namespace Domain
{
    public interface IServiceFactory
    {

        IBillService CreateBillService(string databaseId, string sessionid);
    }
}