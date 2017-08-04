using Budget;
using NUnit.Framework;

namespace InterfaceTest.validatorTest
{
    [TestFixture]
    public class DateInputValidatorTest
    {

        private DateInputValidator DateInputValidator;

        [SetUp]
        public void SetUp()
        {
            DateInputValidator = new DateInputValidator();
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
            bool candidate1isValid = DateInputValidator.ValidateDate(candidate1);
            bool candidate2isValid = DateInputValidator.ValidateDate(candidate2);
            bool candidate3isValid = DateInputValidator.ValidateDate(candidate3);
            bool candidate4isValid = DateInputValidator.ValidateDate(candidate4);

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
            bool isValid = DateInputValidator.ValidateDate(candidate);

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
