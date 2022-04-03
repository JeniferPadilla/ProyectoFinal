using EconomicManagementAPP.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;


namespace EconomicManagementAPP.test
{

    [TestClass]
    public class PasswordTest
    {

        [TestMethod]
        public void Passwordlength_ReturnError()
        {
            var password = new ValidationsPassword();
            var data = "12345";

            var context = new ValidationContext(new { Password = data });

            var testResult = password.GetValidationResult(data, context);

            Assert.AreEqual("The password should have min eight characters", testResult?.ErrorMessage);
        }


         [TestMethod]
        public void PasswordLetter_ReturnError()
        {
            var password = new ValidationsPassword();
            var data = "abcdefghi1233";

            var context = new ValidationContext(new { Password = data });

            var testResult = password.GetValidationResult(data, context);

            Assert.AreEqual("The password should have min one capital letter", testResult?.ErrorMessage);
        }

        [TestMethod]
        public void NullData_NoErrorMessage()
        {
            var password = new ValidationsPassword();
            string data = null;

            var context = new ValidationContext(new { Password = data });

            var testResult = password?.GetValidationResult(data, context);

            Assert.AreEqual("The password must exits", testResult?.ErrorMessage);
        }

        [TestMethod]
        public void PasswordNumber_ReturnError()
        {
            var password = new ValidationsPassword();
            var data = "abcdefghiAA";

            var context = new ValidationContext(new { Password = data });

            var testResult = password.GetValidationResult(data, context);

            Assert.AreEqual("The password should have min one number", testResult?.ErrorMessage);
        }
    }
}
