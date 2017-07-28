namespace Domain
{
    class NullPayDayService : IPayDayService
    {
        public static NullPayDayService Singleton = new NullPayDayService();

        #region Public Methods

        public virtual void AddPayDay(IPayDay payDay)
        {
            //Do Nothing
        }

        public virtual void DeletePayDay(int recordId)
        {
            //Do Nothing
        }

        public virtual IPayDay GetPayDay(int recordId)
        {
            return null;
        }

        public virtual IPayDay[] GetPayDays()
        {
            return new IPayDay[0];
        }


        public virtual void UpdatePayDay(IPayDay payDay)
        {
            //Do Nothing
        }

        #endregion
    }
}
