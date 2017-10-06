using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePractice.Calculator.Interfaces;

namespace CodePractice.Calculator
{
    class Formatter : IFormatter
    {
        public int? StringToInt(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int?[] StringArrayToIntArray(string[] s)
        {
            try
            {
                int?[] output = new int?[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    output[i] = Convert.ToInt32(s);
                }
                return output;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
