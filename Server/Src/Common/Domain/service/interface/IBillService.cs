namespace Domain
{
    public interface IBillService
    {

        void AddBill(IBill sprint);

        void DeleteBill(int recordId);

        IBill GetBill(int recordId);
        IBill[] GetBills();

        void UpdateBill(IBill sprint);

    }
}