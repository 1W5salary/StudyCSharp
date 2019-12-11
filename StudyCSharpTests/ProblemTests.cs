using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp.Tests
{
    [TestClass()]
    public class ProblemTests
    {

        [TestMethod()]
        public void PublishTest()
        {
            Problem problem = new Problem();
            problem.reward = -1;
            Assert.AreEqual(problem.reward, 0);
            problem.reward = 5;
            Assert.AreEqual(problem, 5);
        }


        //[TestMethod()]
        //public void PublishTest()
        //{
        //    Assert.Fail();
        //}
    }
}