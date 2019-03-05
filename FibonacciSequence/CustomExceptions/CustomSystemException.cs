using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class CustomSystemException : Exception
    {
        public CustomSystemException(string message, Exception innerException)
            :base(message,innerException)
        {

        }
    }
}
       