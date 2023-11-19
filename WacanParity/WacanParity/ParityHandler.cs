using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class ParityHandler
    {
        public static void HandleParityOption()
        {
            string bitSet = InputHandler.GetBinaryInput("Enter a set of bits:");
            string parityOption = InputHandler.GetParityOption();
            Console.WriteLine("\nChecking if the bit set has the selected parity:");
            Console.WriteLine($"Input bit set: {bitSet}");
            string parityResult = ParityCalculator.GetSpecificParity(bitSet, parityOption);
            Console.WriteLine($"Parity Bit: {parityResult}");

            if (parityResult == "1")
            {
                Console.WriteLine("The set of bits has an error\n");
            }
            else
            {
                Console.WriteLine("The set of bits does not have an error\n");
            }
        }
    }
}
