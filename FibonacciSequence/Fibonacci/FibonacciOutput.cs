using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciOutput: IOutput
    {
        private readonly List<int> _numbersList;
        private ICalculation _fibonacciCalculations;
        private int _fibonacciCalc;
        private string nthElement;
        private int _intInput;

        public FibonacciOutput(ICalculation calculation)
        {
            _numbersList = new List<int>();
            _fibonacciCalculations = calculation;
        }

        public void Output(string input)
        {    
            _intInput = Convert.ToInt32(input);
            for (int i = 0; i < _intInput; i++)
            {
                _fibonacciCalc = _fibonacciCalculations.Calculations(i);
                _numbersList.Add(_fibonacciCalc);
            }

            nthElement = Convert.ToString(_numbersList[Convert.ToInt32(_intInput) - 1]);
            Console.WriteLine("Inputed Value {0}\n{1}'th Value {2}\nComplete Fibonacci Sequence: {3} \n ", _intInput, _intInput, nthElement, String.Join(", ", _numbersList.ToList()));
            Console.ReadLine();
            return;
        }



    }
}
