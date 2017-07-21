namespace Domain
{
    public interface IAccountService
    {

        void AddAccount(IAccount account);
        void AddBill(IBill bill, IAccount account);

        void DeleteAccount(int recordId);

        IAccount GetAccount(int recordId);
        IAccount[] GetAccounts();

        IBill GetBill(int recordId);
        IBill[] GetBills(int accountRecordId);

        void UpdateAccount(IAccount account);
        void UpdateBill(IBill bill);
    }
}