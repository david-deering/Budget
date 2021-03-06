﻿using NUnit.Framework;
using Presentation;
using System;

namespace Test.PresentationTests
{
    [TestFixture]
    public class MainWindowPresenterTest : AbstractTest
    {

        private MainWindowPresenter Presenter;

        [SetUp]
        public void SetUp()
        {
            Presenter = new MainWindowPresenter();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_GetPayDaysInMonth()
        {
            //set-up
            CreatePayDayData();
            PayDayModel[] models = new PayDayModel[0];

            //pre-conditions
            Assert.AreEqual(0, models.Length);

            //exercise
            models = Presenter.GetPayDaysInMonth(new DateTime(2017, 05, 05));

            //post-conditions
            Assert.AreEqual(1, models.Length);
        }

        [Test]
        public void TestBlueSky_CreateHeaders()
        {
            //set-up
            string[] headers = new string[0];

            //pre-conditions
            Assert.AreEqual(0, headers.Length);

            //exercise
            headers = Presenter.GetHeaderValues();

            //post-conditions
            Assert.AreEqual("Company Name", headers[0]);
            Assert.AreEqual("Monthly Payment", headers[1]);
            Assert.AreEqual("Date Due", headers[2]);
            Assert.AreEqual("Account Balance", headers[3]);
        }


        [Test]
        public void TestBlueSky_GetAccounts()
        {
            //set-up
            CreateAccountData();
            AccountModel[] accounts = new AccountModel[0];

            //pre-conditions
            Assert.AreEqual(0, accounts.Length);

            //exercise
            accounts = Presenter.GetAccounts();

            //post-conditions
            Assert.AreEqual(1, accounts.Length);
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

    }
    #endregion
}
