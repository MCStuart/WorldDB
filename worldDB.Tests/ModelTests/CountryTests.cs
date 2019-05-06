using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorldDB.Controllers;
using WorldDB.Models;

namespace WorldDB.Tests
{
    [TestClass]
    public class CountryControllerTest
    {

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        //Arrange
        CountryController controller = new CountryController();

        //Act
        IActionResult view = controller.Create();

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

    }
}
