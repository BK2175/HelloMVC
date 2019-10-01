using System;
using Xunit;

using HelloMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Returns_Viewresult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
