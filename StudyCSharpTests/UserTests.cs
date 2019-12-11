using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void TestUuerName()
        {
            User user = new User();
            user.Name = "admin";
            Assert.AreEqual(user.Name,"系统管理员");
        }

    }
}