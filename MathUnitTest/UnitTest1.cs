using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathlib;

namespace MathUnitTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void Addition()
        {
            mathlib.math math = new math();
            Assert.AreEqual(20, math.Add(10, 10),"Additon values are equal and testing successful");
        }
        [TestMethod]
        public void Subtraction()
        {
            mathlib.math math = new math();
            Assert.AreEqual(5, math.Subtract(10, 5), "Subtraction values are equal and testing successful");
        }
        [TestMethod]
        public void Multiplication()
        {
            mathlib.math math = new math();
            Assert.AreEqual(100, math.Multiply(10, 10), "Multiplied values are equal and testing successful");
        }
    }
}
