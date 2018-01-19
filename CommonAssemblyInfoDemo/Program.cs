using System;
using CommonAssemblyInfo.Domain;

namespace CommonAssemblyInfoDemo
{
    internal class Program
    {
        /// <summary>
        /// Takes in an amount and tax rate, and then calculates the applicable tax.
        /// </summary>
        private static void Main(string[] args)
        {
            var model = new ConsoleTaxRateUI().GetModel();
            var result = new TaxCalculationCommand(model).Execute();

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
