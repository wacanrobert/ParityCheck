using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class BCCCalculator
    {
        public static string GetBCCWithParity(string[] blockOfCharacters)
        {
            if (blockOfCharacters.Length == 0)
            {
                Console.WriteLine("Block of characters is empty!");
                return string.Empty;
            }

            string bcc = blockOfCharacters[0];

            for (int i = 1; i < blockOfCharacters.Length; i++)
            {
                bcc = CalculateXOR(bcc, blockOfCharacters[i]);
            }

            // Calculate EVEN and ODD Parity
            int bccInt = Convert.ToInt32(bcc, 2);
            string evenParity = bccInt % 2 == 0 ? "0" : "1";
            string oddParity = bccInt % 2 == 0 ? "1" : "0";

            // Calculate BCC Parity Bit
            string bccParityBit = CalculateXOR(evenParity, oddParity);

            return $"{bcc}{evenParity}{oddParity}{bccParityBit}";
        }

        public static string GetBCC(string[] blockOfBits)
        {
            if (blockOfBits.Length == 0)
            {
                Console.WriteLine("Block of bits is empty!");
                return string.Empty;
            }

            string bcc = blockOfBits[0];

            for (int i = 1; i < blockOfBits.Length; i++)
            {
                bcc = CalculateXOR(bcc, blockOfBits[i]);
            }

            return bcc;
        }

        public static bool CheckError(string[] blockOfBits, string bcc)
        {
            string calculatedBCC = GetBCC(blockOfBits);
            return calculatedBCC != bcc;
        }

        public static string GetBCCWithParity(string blockOfBits)
        {
            List<int> bits = blockOfBits.Select(bit => int.Parse(bit.ToString())).ToList();
            int bcc = bits.Aggregate((x, y) => x ^ y);

            string lrc = Convert.ToString(bcc, 2).PadLeft(blockOfBits.Length, '0');
            string evenParity = bcc % 2 == 0 ? "0" : "1";
            string oddParity = bcc % 2 == 0 ? "1" : "0";

            return $"{blockOfBits}{evenParity}{oddParity}{lrc}";
        }

        private static string CalculateXOR(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                throw new InvalidOperationException("Strings must have equal lengths.");
            }

            char[] result = new char[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                result[i] = str1[i] == str2[i] ? '0' : '1';
            }

            return new string(result);
        }
    }
}
