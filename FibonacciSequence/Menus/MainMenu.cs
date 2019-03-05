using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class MainMenu : IMenu
    {  
        //Notes
        //The Menu class is separated from the Fibonacc Class to allow for the selection of alternative Math calculations.
        private FibonacciStartUp _fibonacci;
        private string _choice;
        private MainMenu _mainMenu;
        public ReusableMethods _reusableMethods;


        public MainMenu(ReusableMethods reusableMethods)
        {
            _reusableMethods = reusableMethods;
        }

        public string InputMenu()
        {
            while (true)
            {
                _fibonacci = new FibonacciStartUp();
                _choice = _reusableMethods.InputMenu("Please choose an option below \n Enter 1 For fibonacci :");
                switch (_choice)
                {
                    case "1":
                        Console.Clear();
                        Start(_fibonacci);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Incorrect value please enter a valid integer:");
                        _mainMenu = new MainMenu(_reusableMethods);
                        _reusableMethods.Input(_mainMenu);
                        break;

                }
                return string.Empty;
            }

        }
        void Start(IStartUp start)
        {
            start.StartUp();
        }
    }
}
