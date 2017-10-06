using System;
using CodePractice.DependencyInjection;
using CodePractice.Calculator.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePractice.StringHandling;

namespace CodePractice
{
    static  class Program
    {
        static void Main(string[] args)
        {
            //BaseClassExample();
            //DependencyInjection();
        }

        /// <summary>
        /// Resolve any dependencies using a class that implements a Unity Container.
        /// </summary>
        public static void DependencyInjection()
        {
            var calc = Resolver.Resolve<ICalc>();
            DelegateMethod(calc.SquareANumber);
        }
        
        /// <summary>
        /// Delegate Method Example: Pass a method as paramenters.
        /// </summary>
        /// <param name="method">The name of the method to be passed.</param>
        public static void DelegateMethod(Func<string, int?> method)
        {
            int? output = method("5");
            Console.WriteLine(output);
        }

        public static void BaseClassExample()
        {
            StringHandler stringHandler = new StringHandler("Hello World!");
            Console.WriteLine("\n");

            stringHandler.PrintXTimes("Extension Method", 5);
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Extension Method Example: Add extra implementation to an object
        /// despite the behaviour(method) not being present in the class itself.
        /// </summary>
        /// <param name="b">The class to add an extension method to.</param>
        /// <param name="text">Text to print.</param>
        /// <param name="x">No. of times to print text.</param>
        public static void PrintXTimes(this StringHandler b, string text, int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
