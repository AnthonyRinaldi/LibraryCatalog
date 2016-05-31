using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryCatalog.Service_Layer.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        UserService UserServiceToTest;

        [TestInitialize]
        public void InitTest()
        {
            UserServiceToTest = new UserService();
        }
            
        [TestMethod]
        public void CheckoutItemTest()
        {
            // Add Mocks for Injected Resources in UserService
            Assert.IsTrue(UserServiceToTest.CheckoutItem("UserId", "ItemId"));
        }
    }
}