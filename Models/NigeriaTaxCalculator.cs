using System.ComponentModel.DataAnnotations;

namespace MiscellaneousApi.Models
{
    public class NigeriaTaxCalculator
    {
        private static double GetConsolidatedReceivedAllowance(double grossIncome)
        {
            double cra = Math.Max(200000, grossIncome * 0.01) + grossIncome* 0.2;
            return cra;
        }
        public static double Calculator(double annualIncome)
        {
            double taxableIncome = annualIncome - GetConsolidatedReceivedAllowance(annualIncome);
            double tax = 0;
            if (taxableIncome <= 300000)
                tax += taxableIncome * 0.07;
            else if (taxableIncome <= 600000)
            {
                tax += 300000 * 0.07;
                tax += (taxableIncome - 300000) * 0.11;
            }
            else if (taxableIncome <= 1100000)
            {
                tax += 300000 * 0.07;
                tax += 300000 * 0.11;
                tax += (taxableIncome - 600000) * 0.15;
            }
            else if (taxableIncome <= 1600000)
            {
                tax += 300000 * 0.07;
                tax += 300000 * 0.11;
                tax += 500000 * 0.15;
                tax += (taxableIncome - 1100000) * 0.19;
            }
            else if (taxableIncome <= 3200000)
            {
                tax += 300000 * 0.07;
                tax += 300000 * 0.11;
                tax += 500000 * 0.15;
                tax += 500000 * 0.19;
                tax += (taxableIncome - 1600000) * 0.21;
            }
            else
            {
                tax += 300000 * 0.07;
                tax += 300000 * 0.11;
                tax += 500000 * 0.15;
                tax += 500000 * 0.19;
                tax += 1600000 * 0.21;
                tax += (taxableIncome - 3200000) * 0.24;
            }
            return tax;

        }
    }
}
