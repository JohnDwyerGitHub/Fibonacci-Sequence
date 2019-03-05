using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciSequence.UnitTests
{
    [TestClass]
    public class FibonacciOutputCalculationTests
    {
        [TestMethod]
        public void FibonacciOutput_Calculation_SucessFulSequence()
        {
            var fibonacciOutput = new FibonacciOutput(new FakeFibonacciCalculation());
        }
    }
    public class FakeFibonacciCalculation: ICalculation
    {
        public int Calculations(int value){
            return 5;
        }
    }
}
