using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.View
{
    class ConsoleView
    {
        public int GetUserChoice()
        {
            Console.WriteLine("Choose a location to visit:");
            Console.WriteLine("1 - Mysterious Forest");
            Console.WriteLine("2 - Deadly Desert");
            Console.WriteLine("3 - Lost Island");
            Console.WriteLine("4 - Icy Caves");
            Console.WriteLine("5 - Volcanic Mountains");
            Console.WriteLine("6 - Customize Hero");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            int chosenLocation;
            if (int.TryParse(choice, out chosenLocation))
            {
                return chosenLocation;
            }
            return -1;
        }

        public string GetStringValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public int GetIntValue(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int value;
            while (!int.TryParse(input, out value))
            {
                Console.Write("Invalid input, please enter a number: ");
                input = Console.ReadLine();
            }
            return value;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
