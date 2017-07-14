namespace Domain
{
    public interface IAccountService
    {

        void AddAccount(IAccount account);

        void DeleteAccount(int recordId);

        IAccount GetAccount(int recordId);
        IAccount[] GetAccounts();

        void UpdateAccount(IAccount account);

    }
}