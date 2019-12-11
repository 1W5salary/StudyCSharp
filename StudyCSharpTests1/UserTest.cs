using NUnit.Framework;
using StudyCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp.Test
{
    [TestFixture()]
    public class UserTest
    {
        [Test()]
        public void RegisterTest()
        {
            User user = new User();
            user.Name = "admin";
            Assert.AreEqual(user.Name, "系统管理员");
        }

        
    }
}