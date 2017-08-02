using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class Balancer
    {

        #region Constructors

        public Balancer(IPayPeriodBuilder[] builders)
        {
            Builders = builders;
        }

        #endregion

        #region Properties

        private IPayPeriodBuilder[] Builders { get; set; }

        #endregion

        #region Public Methods

        public void BalanceBudget()
        {
            List<IPayPeriodBuilder> buildersWithDeficits = Builders.Where(b => b.Deficit > 0).ToList();
            buildersWithDeficits.ForEach(BalanceSurpluses);
        }

        #endregion

        #region Helper Methods

        private void BalanceSurplus(IPayPeriodBuilder builderWithSurplus, IPayPeriodBuilder builderWithDeficit)
        {
            if (builderWithSurplus.Surplus >= builderWithDeficit.Deficit)
            {
                builderWithSurplus.Surplus -= builderWithDeficit.Deficit;
                builderWithDeficit.Deficit = 0;
                return;
            }

            builderWithDeficit.Deficit -= builderWithSurplus.Surplus;
            builderWithSurplus.Surplus = 0;
        }

        private void BalanceSurpluses(IPayPeriodBuilder builderWithDeficit)
        {
            List<IPayPeriodBuilder> buildersWithSurpluses = Builders.Where(b => b.Surplus > 0 && b.StartDate < builderWithDeficit.StartDate).ToList();

            foreach (IPayPeriodBuilder builder in buildersWithSurpluses)
            {
                if (builderWithDeficit.Deficit > 0)
                {
                    BalanceSurplus(builder, builderWithDeficit);
                }
            }
        }

        #endregion

    }
}
