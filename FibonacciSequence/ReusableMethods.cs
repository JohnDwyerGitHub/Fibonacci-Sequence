using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FibonacciSequence
{
    public class ReusableMethods
    {
        //Notes
        //This is a Composition class to allow for quick writing of reusable code and avoiding fragile hierarchies.
        private string _inputedValue;
        public string InputMenu(string message)
        {
            Console.Write(message);
            _inputedValue = Console.ReadLine();
            return _inputedValue;
        }

        public void Input(IMenu input)
        {
            input.InputMenu();
        }

        public void LogError(Exception ex)
        {
            using (var StreamWriter = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\ErrorLog.txt"))
            {
                StreamWriter.WriteLine("Error {0}  Date {1}", ex, DateTime.Now);
            }
        }
    }

}
