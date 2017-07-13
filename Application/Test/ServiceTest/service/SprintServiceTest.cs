using Domain;
using NUnit.Framework;
using System;
using System.Linq;

namespace Dmi.ServiceTest
{
    [TestFixture]
    public class BillServiceTest : AbstractServiceTest
    {
        private IBillService Service;

        [SetUp]
        public void SetUp()
        {
            Service = ServiceFactory.CreateBillService(string.Empty, Guid.NewGuid().ToString());
            DeleteAllBills();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Add()
        {
            // set-up
            IBill bill = CreateBill();

            // pre-conditions
            Assert.IsNull(Service.GetBill(bill.RecordId));

            // exercise
            Service.AddBill(bill);
            IBill persistedBill = Service.GetBill(bill.RecordId);

            // post-conditions
            Assert.AreEqual(persistedBill, bill);
        }

        [Test]
        public void TestBlueSky_Delete()
        {
            // set-up
            IBill bill = CreateBill();

            Service.AddBill(bill);

            // pre-conditions
            Assert.AreEqual(1, Service.GetBills().Length);

            // exercise
            Service.DeleteBill(bill.RecordId);

            // post-conditions
            Assert.AreEqual(0, Service.GetBills().Length);
        }

        [Test]
        public void TestBlueSky_Get()
        {
            // set-up
            IBill bill = CreateBill();

            Service.AddBill(bill);

            // exercise
            IBill persistedBill = Service.GetBill(bill.RecordId);

            // post-conditions
            Assert.AreEqual(persistedBill, bill);
        }

        [Test]
        public void TestBlueSky_Update()
        {
            // set-up
            IBill bill = CreateBill();

            Service.AddBill(bill);

            IBill persistedBill = Service.GetBill(bill.RecordId);

            // exercise
            //            persistedBill.Period.EffectiveStartDate = new DateTime(2017, 04, 17);
            Service.UpdateBill(persistedBill);

            // post-conditions
            Assert.AreEqual(persistedBill, bill);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_AddInvalidBill()
        {
            // set-up
            IBill bill = null;

            // pre-conditions
            Assert.AreEqual(0, Service.GetBills().Length);

            // exercise
            Service.AddBill(bill);

            // post-conditions
            Assert.AreEqual(0, Service.GetBills().Length);
        }

        [Test]
        public void TestNonBlueSky_DeleteBillNotFound()
        {
            // set-up
            IBill bill = CreateBill();
            Service.AddBill(bill);

            // pre-conditions
            Assert.AreEqual(1, Service.GetBills().Length);

            // exercise
            Service.DeleteBill(0);

            // post-conditions
            Assert.AreEqual(1, Service.GetBills().Length);
        }

        [Test]
        public void TestNonBlueSky_UpdateWithInvalidBill()
        {
            // set-up
            IBill bill = CreateBill();

            Service.AddBill(bill);

            IBill persistedBill = Service.GetBill(bill.RecordId);

            // exercise
            persistedBill = null;
            Service.UpdateBill(persistedBill);

            // post-conditions
            Assert.AreNotEqual(persistedBill, bill);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            DeleteAllBills();
        }

        #region Helper Methods

        private IBill CreateBill()
        {
            Bill bill = new Bill();
            bill.DateOwed = new DateTime(2017, 05, 05);
            bill.MonthlyPayment = 10.15m;
            bill.Name = "Test Company Name";
            bill.RecordId = 0;
            bill.TotalOwed = 110.15m;
            return bill; ;
        }

        private void DeleteAllBills()
        {
            IBill[] bills = Service.GetBills();

            bills.ToList().ForEach(DeleteBill);
        }

        private void DeleteBill(IBill bill)
        {
            Service.DeleteBill(bill.RecordId);
        }
    }
        #endregion
}