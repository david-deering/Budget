using Domain;
using NUnit.Framework;
using Service;
using System;

namespace Dmi.ServiceTest.builder
{
    [TestFixture]
    public class BalancerTest
    {

        private Balancer Balancer;
        private IPayPeriodBuilder[] Builders;

        [SetUp]
        public void SetUp()
        {

        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Surplus_GreaterThanDeficit()
        {
            //set-up
            Builders = CreateBuilders();
            decimal surplus = Builders[0].Surplus = 20m;
            decimal deficit = Builders[1].Deficit = 10m;
            Balancer = new Balancer(Builders);

            //pre-conditions
            Assert.IsTrue(surplus > deficit);

            //exercise
            Balancer.BalanceBudget();

            //post-conditions
            Assert.AreEqual(10, Builders[0].Surplus);
            Assert.AreEqual(0, Builders[1].Deficit);
        }

        [Test]
        public void TestBlueSky_Surplus_LessThanDeficit()
        {
            //set-up
            Builders = CreateBuilders();
            decimal surplus = Builders[0].Surplus = 5m;
            decimal deficit = Builders[1].Deficit = 10m;
            Balancer = new Balancer(Builders);

            //pre-conditions
            Assert.IsTrue(surplus < deficit);

            //exercise
            Balancer.BalanceBudget();

            //post-conditions
            Assert.AreEqual(0, Builders[0].Surplus);
            Assert.AreEqual(5, Builders[1].Deficit);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_()
        {

        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }

        #region Helper Methods


        private IPayPeriodBuilder[] CreateBuilders()
        {
            IPayDay payDay1 = new PayDay();
            payDay1.Date = new DateTime(2017, 05, 01);
            payDay1.Amount = 0m;
            payDay1.RecordId = 1;

            IPayDay payDay2 = new PayDay();
            payDay2.Date = new DateTime(2017, 05, 20);
            payDay2.Amount = 0;
            payDay2.RecordId = 2;

            IPayPeriodBuilder builder1 = new PayPeriodBuilder(payDay1, payDay2.Date);
            builder1.Surplus = 0;

            IPayPeriodBuilder builder2 = new PayPeriodBuilder(payDay2, null);
            builder2.Surplus = 0;
            builder2.Deficit = 0;

            return new[] { builder1, builder2 };
        }

        #endregion

    }
}
