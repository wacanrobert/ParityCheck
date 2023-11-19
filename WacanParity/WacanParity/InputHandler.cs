using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class InputHandler
    {
        public static string GetBinaryInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (!IsBinary(input))
                {
                    Console.WriteLine("Invalid input! Please enter binary data (0s and 1s) only.");
                }
            } while (!IsBinary(input));
            return input;
        }

        public static bool IsBinary(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        public static string GetParityOption()
        {
            string option;
            do
            {
                Console.WriteLine("Choose Parity:");
                Console.WriteLine("1. EVEN");
                Console.WriteLine("2. ODD");
                option = Console.ReadLine();
            } while (option != "1" && option != "2");

            return option;
        }

        public static string[] GetBlockOfBits()
        {
            Console.WriteLine("Enter the number of lines in the block:");
            if (!int.TryParse(Console.ReadLine(), out int lines))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return GetBlockOfBits();
            }

            Console.WriteLine("Enter the number of bits per line:");
            if (!int.TryParse(Console.ReadLine(), out int bits))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return GetBlockOfBits();
            }

            string[] block = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                block[i] = GetBinaryInput($"Enter line {i + 1} of {lines} (length: {bits}):");
                if (block[i].Length != bits)
                {
                    Console.WriteLine($"Invalid input! The line must have {bits} bits.");
                    i--;
                }
            }

            return block;
        }

        public static string[] GetBlockOfCharacters()
        {
            Console.WriteLine("Enter the number of lines in the block:");
            if (!int.TryParse(Console.ReadLine(), out int lines))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return GetBlockOfCharacters();
            }

            Console.WriteLine("Enter the number of characters per line:");
            if (!int.TryParse(Console.ReadLine(), out int characters))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return GetBlockOfCharacters();
            }

            string[] block = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"Enter line {i + 1} of {lines} (length: {characters}):");
                block[i] = Console.ReadLine();
                if (block[i].Length != characters)
                {
                    Console.WriteLine($"Invalid input! The line must have {characters} characters.");
                    i--;
                }
            }

            return block;
        }
    }
}
