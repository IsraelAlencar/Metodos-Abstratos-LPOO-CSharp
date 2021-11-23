using System;
using System.Collections.Generic;
using System.Text;

namespace Tax.Entities {
    class Individual : TaxPayer {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            if (AnualIncome < 20000.00) {
                return (AnualIncome * 15 / 100) - (HealthExpenditures / 2);
            }

            else {
            return (AnualIncome * 25 / 100) - (HealthExpenditures / 2);
            }
        }
    }
}
