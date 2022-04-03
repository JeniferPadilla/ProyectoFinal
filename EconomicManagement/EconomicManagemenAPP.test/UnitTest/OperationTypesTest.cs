using EconomicManagementAPP.Controllers;
using EconomicManagementAPP.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

namespace EconomicManagementAPP.test
{
    [TestClass]
    public class OperationTypesTest
    {
        private RepositorieOperationTypes repositorieOperationTypes;

        public OperationTypesTest()
        {
            repositorieOperationTypes = new RepositorieOperationTypes();
        }

        [TestMethod]
        public void OperationTypesCreate_ReturnError()
        {
            var accountTypesController = new OperationTypesController(repositorieOperationTypes);

            var actionResult = accountTypesController.Create() as RedirectToActionResult;            
           
            Assert.AreEqual(actionResult?.ControllerName, "Users");
            Assert.AreEqual(actionResult?.ActionName, "Login");



        }



    }
}
