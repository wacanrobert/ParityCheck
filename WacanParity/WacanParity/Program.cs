using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace WacanParity
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Determine Parity of a set of bits");
                Console.WriteLine("2. Find BCC of a block of character bits");
                Console.WriteLine("3. Check for errors in a block of character bits using its BCC");
                Console.WriteLine("4. Find BCC with Parity");
                Console.WriteLine("Type 'q' to exit");

                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                ProcessOption(userInput);
            }
        }

        static void ProcessOption(string option)
        {
            switch (option)
            {
                case "1":
                    ParityHandler.HandleParityOption();
                    break;
                case "2":
                    BCCHandler.HandleBCCOption();
                    break;
                case "3":
                    ErrorChecker.HandleErrorCheckOption();
                    break;
                case "4":
                    BCCWithParityHandler.HandleBCCWithParityOption();
                    break;
                default:
                    Console.WriteLine("Invalid option! Please choose a valid option or type 'quit' to exit.");
                    break;
            }
        }
    }
}
