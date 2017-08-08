using Budget;
using NUnit.Framework;

namespace InterfaceTest.validatorTest
{
    [TestFixture]
    public class DateInputValidatorTest
    {


        [SetUp]
        public void SetUp()
        {
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Validate()
        {
            //set-up
            string candidate1 = "05/05/2017";
            string candidate2 = "05 05 2017";
            string candidate3 = "05-05-2017";
            string candidate4 = "5/5/2017";

            //exercise
            bool candidate1isValid = Validator.ValidateDate(candidate1);
            bool candidate2isValid = Validator.ValidateDate(candidate2);
            bool candidate3isValid = Validator.ValidateDate(candidate3);
            bool candidate4isValid = Validator.ValidateDate(candidate4);

            //post-conditions
            Assert.True(candidate1isValid);
            Assert.True(candidate2isValid);
            Assert.True(candidate3isValid);
            Assert.True(candidate4isValid);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_Validate_MissingField()
        {
            //set-up
            string candidate = "05/2017";

            //exercise
            bool isValid = Validator.ValidateDate(candidate);

            //post-conditions
            Assert.False(isValid);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }

        #region Helper Methods



        #endregion

    }
}
