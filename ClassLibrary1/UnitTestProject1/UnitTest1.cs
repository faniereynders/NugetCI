﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var m = new MathClass();

            var expected = 2;

            var actual = m.Sum(1, 1);

            Assert.AreEqual(expected, actual);


        }
    }
}
