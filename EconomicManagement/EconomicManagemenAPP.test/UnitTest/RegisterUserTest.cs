using EconomicManagementAPP.Validations;
using EconomicManagementAPP.Controllers;
using EconomicManagementAPP.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using EconomicManagementAPP.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EconomicManagementAPP.test
{
    [TestClass]
    public  class RegisterUserTest
    {
        private RepositorieUsers repositorieUsers;

        public RegisterUserTest()
        {
            repositorieUsers = new RepositorieUsers();
        }

        [TestMethod]
        public void RegisterUser_ReturnError()
        {
            //string expectedView = "Create";
            var usersController = new UsersController(repositorieUsers);
            // Act
            var actionResult = usersController.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(actionResult,
                "El ActionResult no debe ser Null.");
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult),
                "El ActionResult debe ser del tipo ViewResult.");
            //Assert.AreEqual(actionResult.ViewName, expectedView,
                //"El nombre de la Vista devuelta debe ser " + expectedView);
        }       


        /*
       [TestMethod]
       public void NullData_NoErrorMessage()
       {
           var firstCapitalLetter = new FirstCapitalLetter();
           string data = null;

           var context = new ValidationContext(new { Name = data });

           var testResult = firstCapitalLetter.GetValidationResult(data, context);

           Assert.IsNull(testResult);
       }*/
    }
}
