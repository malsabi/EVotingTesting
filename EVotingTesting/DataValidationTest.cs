using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EVotingTesting
{
    [TestClass]
    public class DataValidationTest
    {
        [TestMethod]
        public void EmailValidationTest()
        {
            Validation.EmailValidation emailValidator = new Validation.EmailValidation();

            bool Result = emailValidator.IsValid("H00345671@hct.ac.ae");

            //Actual Value: True
            //Expected Value: False

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void StudentIdValidationTest()
        {
            Validation.StudentIdValidation studentIdValidator = new Validation.StudentIdValidation();

            bool Result = studentIdValidator.IsValid("H00345678");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void NameValidationTest()
        {
            Validation.NameValidation nameValidator = new Validation.NameValidation();

            bool Result = nameValidator.IsValid("Aisha");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void NationalIdValidationTest()
        {
            Validation.NationalIdValidation nationalIdValidator = new Validation.NationalIdValidation();

            bool Result = nationalIdValidator.IsValid("000-1111-0000111-1");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void GenderValidationTest()
        {
            Validation.GenderValidation genderValidator = new Validation.GenderValidation();

            bool Result = genderValidator.IsValid("Male");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }
    }
}