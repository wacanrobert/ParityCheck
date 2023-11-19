using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class BCCWithParityHandler
    {
        public static void HandleBCCWithParityOption()
        {
            string[] blockForBCCWithParity = InputHandler.GetBlockOfBits();
            Console.WriteLine("\nFinding BCC through LRC, EVEN-set, ODD-set parity bits, and BCC parity:");

            // Calculate BCC with Parity
            BCCWithParityCalculator.CalculateBCCWithParity(new List<string>(blockForBCCWithParity), blockForBCCWithParity[0].Length);
        }
        /*
       public static void HandleBCCWithParityOption()
       {
           string[] blockOfCharacters = InputHandler.GetBlockOfCharacters();
           Console.WriteLine("\nFinding BCC through LRC, EVEN-set, ODD-set parity bits, and BCC parity:");

           // Calculate BCC with LRC, EVEN-set, ODD-set parity bits, and BCC parity
           string bccWithParity = BCCCalculator.GetBCCWithParity(blockOfCharacters);

           // Display the result
           Console.WriteLine($"BCC with Parity: {bccWithParity}");
       }

       public static void HandleBCCWithParityOption()
       {
           string blockForBCCWithParity = InputHandler.GetBinaryInput("\nEnter a block of character bits to find its BCC with parity:");
           Console.WriteLine("\nFinding BCC through LRC, EVEN-set, ODD-set parity bits, and BCC parity:");

           // Calculate BCC with LRC, EVEN-set, ODD-set parity bits, and BCC parity
           string bccWithParity = BCCCalculator.GetBCCWithParity(blockForBCCWithParity);

           // Display the result
           Console.WriteLine($"BCC with Parity: {bccWithParity}");
       }

       public static void HandleBCCWithParityOption()
       {
           string blockForBCCWithParity = InputHandler.GetBinaryInput("\nEnter a block of character bits to find its BCC with parity:");
           Console.WriteLine("\nFinding BCC through LRC, EVEN-set, ODD-set parity bits, and BCC parity:");
           string bccWithParity = BCCCalculator.GetBCCWithParity(blockForBCCWithParity);
           Console.WriteLine($"BCC with Parity: {bccWithParity}");
       }
       */
    }
}
