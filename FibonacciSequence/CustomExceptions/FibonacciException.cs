using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciException : Exception
    {
        public FibonacciException(string message, Exception innerException)
            :base(message,innerException)
        {

        }
    }
}
       