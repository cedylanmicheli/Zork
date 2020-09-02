using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim());
            Console.WriteLine(command);

            //if (inputString == "QUIT") 
            //{
            //    Console.WriteLine("Thank you for playing.");
            //}
            //else if (inputString == "LOOK") 
            //{
            //    Console.WriteLine("This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork' lies by the door.");
            //}
            //else 
            //{
            //    Console.Write("Unrecognized command.");
            //}
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse(commandString, ignoreCase: true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }
}
