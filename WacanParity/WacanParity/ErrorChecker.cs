using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class ErrorChecker
    {
        public static void HandleErrorCheckOption()
        {
            string[] blockToCheck = InputHandler.GetBlockOfBits();
            string bccToCheck = InputHandler.GetBinaryInput("Enter the BCC to check:");
            bool hasError = BCCCalculator.CheckError(blockToCheck, bccToCheck);
            Console.WriteLine($"Does the block of character bits have an error? {hasError}");
        }
    }
}
