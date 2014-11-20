using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContinuousApp.Tests
{
    using System.Web.Mvc;

    using ContinuousApp.Controllers;
    using ContinuousApp.Models;

    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public void RunOk()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var actual = controller.Index();
            var actualResult = actual as ViewResult;

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(ViewResult));
            Assert.IsNotNull(actualResult);
            Assert.IsInstanceOfType(actualResult.Model, typeof(HomeViewModel));
            Assert.AreEqual("Hola Integración!", ((HomeViewModel)actualResult.Model).Message);
        }
    }
}
