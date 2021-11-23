using System;
using System.Globalization;
using Tax.Entities;
using System.Collections.Generic;

namespace Tax {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c): ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "i") {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }

                else if (type == "c") {
                    Console.Write("Number of employees: ");
                    int numEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numEmployees));
                }
            }

            double totalTaxes = 0;

            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer x in list) {
                totalTaxes += x.Tax();
                Console.WriteLine(x.Name + ": $ " + x.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
