using NUnit.Framework;
using StudyCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp.Test
{
    [TestFixture()]
    public class StackTest
    {
        [Test()]
        public void StackTest1()
        {
            Stack stack = new Stack(10);
            Assert.AreEqual(stack.container.Length,10);
            Assert.AreEqual(stack.container[0],null);
        }

        [Test()]
        public void PushTest()
        {
            Stack stack = new Stack(10);
            stack.Push(1,2,3,4,5,6,7,8,9,10);
            Assert.AreEqual(stack.container[0], 1);
            Assert.AreEqual(stack.container[5], 6);
            Assert.AreEqual(stack.container[9], 10);
            stack.Push(20);
            Assert.AreEqual(stack.container[9], 10);
        }

        [Test()]
        public void PopTest()
        {
            Stack stack = new Stack(10);
            stack.Push(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            stack.Pop();
            Assert.AreEqual(stack.container[9], null);
            stack.Pop(); stack.Pop(); stack.Pop(); stack.Pop(); stack.Pop(); stack.Pop(); stack.Pop(); stack.Pop(); 
            Assert.AreEqual(stack.container[0], 1);
            stack.Pop();
            Assert.AreEqual(stack.container[0], null);
        }
    }
}