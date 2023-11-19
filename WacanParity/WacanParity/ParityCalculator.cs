using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WacanParity
{
    public static class ParityCalculator
    {
        public static string GetSpecificParity(string bitSet, string parityOption)
        {
            int count = bitSet.Count(bit => bit == '1');

            if ((count % 2 == 0 && parityOption == "1") || (count % 2 != 0 && parityOption == "2"))
            {
                return "0";
            }
            else
            {
                return "1";
            }
        }
    }
}
