using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciCalculation : ICalculation
    {
        //Notes
        //This class handles the calculation of the Fibonacci squence.
        private int _a;
        private int _b;
        private int _temp;

        public FibonacciCalculation()
        {
            _a = 0;
            _b = 1;
            _temp = 0;
        }
        public int Calculations(int n)
        {
            _a = 0;
            _b = 1;
            _temp = 0;

            for (int i = 0; i < n; i++)
            {
                _temp = _a;
                _a = _b;
                _b = _temp + _b;
            }
            return _a;
        }
    }
}