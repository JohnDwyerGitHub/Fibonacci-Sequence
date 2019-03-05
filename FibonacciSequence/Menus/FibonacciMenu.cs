using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciMenu : IMenu
    {
        //Notes
        //This class handles the collecting of inputs for the fibonacci sequence.
        private string _number;
        public ReusableMethods _reusableMethods;


        public FibonacciMenu(ReusableMethods reusableMethods)
        {
            _reusableMethods = reusableMethods;
        }
        public string InputMenu()
        {
            _number = _reusableMethods.InputMenu("Please do one of the following actions: \n- Enter A Number for Fibonacci \n\t(Tap enter to start a new sequence, type clear to clean the console or quit to exit):");
            return _number;
        }
    }
}
