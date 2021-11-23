using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities {
    class Company : TaxPayer{
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (NumberOfEmployees < 11) {
                return AnualIncome * 14 / 100;
            }

            else {
                return AnualIncome * 14 / 100;
            }
        }
    }
}
