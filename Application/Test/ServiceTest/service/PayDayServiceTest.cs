using Domain;
using NUnit.Framework;
using System;
using System.Linq;

namespace Dmi.ServiceTest.service
{
    [TestFixture]
    public class PayDayServiceTest : AbstractServiceTest
    {

        private IPayDayService PayDayService;

        [SetUp]
        public void SetUp()
        {
            PayDayService = ServiceFactory.CreatePayDayService();
        }


        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_AddPayDay()
        {
            // set-up
            IPayDay payDay = CreatePayDay();

            // pre-conditions
            Assert.IsNull(PayDayService.GetPayDay(payDay.RecordId));

            // exercise
            PayDayService.AddPayDay(payDay);
            IPayDay persistedPayDay = PayDayService.GetPayDay(payDay.RecordId);

            // post-conditions
            Assert.AreEqual(persistedPayDay, payDay);
        }

        [Test]
        public void TestBlueSky_DeletePayDay()
        {
            // set-up
            IPayDay payDay = CreatePayDay();

            PayDayService.AddPayDay(payDay);

            // pre-conditions
            Assert.AreEqual(1, PayDayService.GetPayDays().Length);

            // exercise
            PayDayService.DeletePayDay(payDay.RecordId);

            // post-conditions
            Assert.AreEqual(0, PayDayService.GetPayDays().Length);
        }

        [Test]
        public void TestBlueSky_GetPayDay()
        {
            // set-up
            IPayDay payDay = CreatePayDay();

            PayDayService.AddPayDay(payDay);

            // exercise
            IPayDay persistedPayDay = PayDayService.GetPayDay(payDay.RecordId);

            // post-conditions
            Assert.AreEqual(persistedPayDay, payDay);
        }

        [Test]
        public void TestBlueSky_UpdatePayDay()
        {
            // set-up
            IPayDay payDay = CreatePayDay();

            PayDayService.AddPayDay(payDay);

            IPayDay persistedPayDay = PayDayService.GetPayDay(payDay.RecordId);

            // exercise
            //            persistedPayDay.Period.EffectiveStartDate = new DateTime(2017, 04, 17);
            PayDayService.UpdatePayDay(persistedPayDay);

            // post-conditions
            Assert.AreEqual(persistedPayDay, payDay);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_AddInvalidPayDay()
        {
            // set-up
            IPayDay payDay = null;

            // pre-conditions
            Assert.AreEqual(0, PayDayService.GetPayDays().Length);

            // exercise
            PayDayService.AddPayDay(payDay);

            // post-conditions
            Assert.AreEqual(0, PayDayService.GetPayDays().Length);
        }

        [Test]
        public void TestNonBlueSky_DeletePayDayNotFound()
        {
            // set-up
            IPayDay payDay = CreatePayDay();
            PayDayService.AddPayDay(payDay);

            // pre-conditions
            Assert.AreEqual(1, PayDayService.GetPayDays().Length);

            // exercise
            PayDayService.DeletePayDay(0);

            // post-conditions
            Assert.AreEqual(1, PayDayService.GetPayDays().Length);
        }

        [Test]
        public void TestNonBlueSky_UpdateWithInvalidPayDay()
        {
            // set-up
            IPayDay payDay = CreatePayDay();

            PayDayService.AddPayDay(payDay);

            IPayDay persistedPayDay = PayDayService.GetPayDay(payDay.RecordId);

            // exercise
            persistedPayDay = null;
            PayDayService.UpdatePayDay(persistedPayDay);

            // post-conditions
            Assert.AreNotEqual(persistedPayDay, payDay);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            DeleteAllPayDays();
        }

        #region Helper Methods

        private IPayDay CreatePayDay()
        {
            IPayDay payDay = new PayDay();
            payDay.Date = new DateTime(2017, 05, 05);
            payDay.Amount = 1000m;
            return payDay;
        }

        private void DeleteAllPayDays()
        {
            IPayDay[] payDays = PayDayService.GetPayDays();

            payDays.ToList().ForEach(DeletePayDay);
        }

        private void DeletePayDay(IPayDay payDay)
        {
            PayDayService.DeletePayDay(payDay.RecordId);
        }
    }
    #endregion
}