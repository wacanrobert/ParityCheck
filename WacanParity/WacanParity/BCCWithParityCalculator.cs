using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public class BCCWithParityCalculator
    {
        public static void CalculateBCCWithParity(List<string> block, int bitLength)
        {
            // Initialize an array to store the count of ones for each line
            int[] onesCountPerLine = new int[block.Count+1]; 

            // Initialize an array to store the count of ones for each column
            int[] columnOnesCount = new int[bitLength];

            // Calculate the count of ones in each line and column
            for (int i = 0; i < block.Count; i++)
            {
                string bits = block[i];

                // Update the columnOnesCount array based on the entered bits
                for (int j = 0; j < bitLength; j++)
                {
                    if (bits[j] == '1')
                    {
                        columnOnesCount[j]++;
                    }
                }

                // Count the number of ones in the current line and store it in the array
                onesCountPerLine[i] = bits.Count(bit => bit == '1');
            }

            // Calculate the BCC based on the count of ones in each column
            StringBuilder bcc = new StringBuilder();
            foreach (int count in columnOnesCount)
            {
                bcc.Append(count % 2 == 0 ? '0' : '1');
            }

            // Add the BCC as the last line in the block
            block.Add(bcc.ToString());

            // Print the block with the BCC
            Console.WriteLine("\nBlock with BCC:");

            foreach (string line in block)
            {
                Console.WriteLine(line);
            }

            // Count the number of ones in the BCC line
            onesCountPerLine[block.Count - 1] = bcc.ToString().Count(bit => bit == '1');

            // Print the block with the BCC
            Console.WriteLine("\nBlock with BCC:");

            foreach (string line in block)
            {
                Console.WriteLine(line);
            }

            Console.Write("\nChoose a parity check (odd/even): ");
            string parityCheckType = Console.ReadLine().ToLower();

            // Initialize a 2-dimensional array
            char[,] array = new char[block.Count, bitLength + 1];

            // Populate the array with bit values from the block
            for (int i = 0; i < block.Count; i++)
            {
                string line = block[i];
                for (int j = 0; j < bitLength; j++)
                {
                    array[i, j] = line[j];
                }

                if (parityCheckType == "even")
                {
                    array[i, bitLength] = CalculateParityBit(onesCountPerLine[i], evenParity: true);
                }
                else if (parityCheckType == "odd")
                {
                    array[i, bitLength] = CalculateParityBit(onesCountPerLine[i], evenParity: false);
                }
            }

            // Print the array
            Console.WriteLine("\nArray with BCC and Parity Check Bit:");

            for (int i = 0; i < block.Count; i++)
            {
                for (int j = 0; j <= bitLength; j++) // Note the change to include the parity check bit column
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }


        private static char CalculateParityBit(int onesCount, bool evenParity)
        {
            return evenParity ? (onesCount % 2 == 0 ? '0' : '1') : (onesCount % 2 == 0 ? '1' : '0');
        }
    }

}
