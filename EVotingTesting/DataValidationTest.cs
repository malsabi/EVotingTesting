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

            bool Result = emailValidator.IsValid("H12345678@hct.ac.ae");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void StudentIdValidationTest()
        {
            Validation.StudentIdValidation studentIdValidator = new Validation.StudentIdValidation();

            bool Result = studentIdValidator.IsValid("H12345678");

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

            bool Result = genderValidator.IsValid("Female");

            //The result value should be true in case the test to be passed.
            Assert.IsTrue(Result);
        }
    }
}