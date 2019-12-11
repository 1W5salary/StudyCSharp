using NUnit.Framework;
using StudyCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp.Test
{
    [TestFixture()]
    public class ProblemTest
    {
        [Test()]
        public void PublishTest()
        {
            Problem problem = new Problem();
            problem.reward = -1;
            Assert.AreEqual(problem.reward, 0);
            problem.reward = 5;
            Assert.AreEqual(problem.reward, 5);
        }
    }
}