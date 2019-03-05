using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var reusableMethods = new ReusableMethods();
            var mainMenu = new MainMenu(reusableMethods);
            try
            {
                //throw new Exception("opps");
                reusableMethods.Input(mainMenu);

            }
            catch (Exception ex)
            {
                reusableMethods.LogError(ex);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("System Error Please Contact Support");
                throw new CustomSystemException("Fibonacci Calculation Failed", ex);               
            }
        }
    }
}