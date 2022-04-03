using EconomicManagementAPP.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace EconomicManagementAPP.test
{
    [TestClass]
    public class MinZeroTest
    {
        [TestMethod]
        public void BalanceLessZero_ReturnError()
        {
            var minZero = new MinZero();
            double data = -1;

            var context = new ValidationContext(new { Name = data });

            var testResult = minZero.GetValidationResult(data, context);

            Assert.AreEqual("The balance must be greater than zero", testResult?.ErrorMessage);
        }

        [TestMethod]
        public void NullData_NoErrorMessage()
        {
            var minZero = new MinZero();
            string data = null;

            var context = new ValidationContext(new { Name = data });

            var testResult = minZero.GetValidationResult(data, context);

            Assert.IsNull(testResult);
        }

        [TestMethod]
        public void BalanceMinOneDecimal_ReturnError()
        {
            var minZero = new MinZero();
            string data = "12k";

            var context = new ValidationContext(new { Name = data });

            var testResult = minZero.GetValidationResult(data, context);

            Assert.AreEqual("The balance must be a decimal", testResult?.ErrorMessage);
        }
    }
}
