using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciStartUp : IStartUp
    {
        //Notes
        //This class handles the start up process by calling the other classes and methods as well as
        //other options such as clear or quit.
        private FibonacciOutput _outPutFunctionality;
        private int _value;
        private FibonacciMenu _fibonacciMenu;
        private string _input;
        private ReusableMethods _reusableMethods;

        public FibonacciStartUp()
        {
            _outPutFunctionality = new FibonacciOutput(new FibonacciCalculation());
        }
        public void StartUp()
        {
            try
            {
                while (true)
                {
                    _reusableMethods = new ReusableMethods();
                    _fibonacciMenu = new FibonacciMenu(_reusableMethods);
                    _input = _fibonacciMenu.InputMenu();

                    if (int.TryParse(_input, out _value))
                    {
                        _outPutFunctionality = new FibonacciOutput(new FibonacciCalculation());
                        _outPutFunctionality.Output(_input);
                        Console.Clear();

                    }
                    else if (_input.ToLower() == "clear")
                    {
                        Console.Clear();
                    }
                    else if (_input.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect value please enter one of the following:");
                    }
                }
            }
            catch (Exception ex)
            {
                _reusableMethods.LogError(ex);
                throw new FibonacciException("Fibonacci Calculation Failed",ex);
            }
        }

    }
}
