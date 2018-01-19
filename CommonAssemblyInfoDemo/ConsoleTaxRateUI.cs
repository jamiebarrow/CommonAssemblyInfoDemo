using System;
using CommonAssemblyInfo.Domain;

namespace CommonAssemblyInfoDemo
{
    public class ConsoleTaxRateUI
    {
        public TaxCalculationInputModel GetModel()
        {
            DisplayFormHeader("Tax Rate Calculation", "Please enter the fields below.");
            var amount = ReadAmount();
            var taxRate = ReadTaxRate();

            var model = new TaxCalculationInputModel
            {
                Amount = amount,
                TaxRate = taxRate
            };
            return model;
        }

        private static void DisplayFormHeader(string header, string description)
        {
            Console.WriteLine($"{header}{Environment.NewLine}{Environment.NewLine}{description}{Environment.NewLine}");
        }

        private static decimal ReadTaxRate()
        {
            return ReadDecimal("Tax Rate (%)");
        }

        private static decimal ReadAmount()
        {
            return ReadDecimal("Amount");
        }

        private static decimal ReadDecimal(string label)
        {
            // TODO: validation, exception handling, retries, etc.

            Console.Write($"{label}: ");
            var input = Console.ReadLine();
            return decimal.Parse(input);
        }
    }
}