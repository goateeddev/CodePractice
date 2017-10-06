using System;
using System.Linq;

namespace CodePractice.StringHandling
{
    public class StringHandler
    {
        public StringHandler()
        {
            Print("String Handler has been initialised.");
        }

        /// <summary>
        /// Program hits the primary constructor before hitting this one.
        /// </summary>
        /// <param name="message">Message to print.</param>
        public StringHandler(string message) : this()
        {
            Print(message);
        }

        public string RepeatString(string s, int n)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }

        public string ArrayToString(int[] array)
        {
            // Swap the sign of the numbers in the array
            array = array.Select(e => -e).ToArray();
            return ToCsvString(array);
        }

        public string ToCsvString(int[] arr)
        {
            return string.Join(", ", arr);
        }

        private static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
