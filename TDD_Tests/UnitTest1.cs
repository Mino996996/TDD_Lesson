using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var val = TDD_Lesson.Calclation.Sum(2, 5);
            Assert.AreEqual(7, val);
        }
    }
}
