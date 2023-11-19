using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class BCCHandler
    {
        public static void HandleBCCOption()
        {
            string[] blockOfBits = InputHandler.GetBlockOfBits();
            Console.WriteLine("\nFinding Block Character Check (BCC):");
            string bcc = BCCCalculator.GetBCC(blockOfBits);
            Console.WriteLine($"Block of Character Bits:");
            foreach (var line in blockOfBits)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine($"BCC: {bcc}");
        }
    }
}
