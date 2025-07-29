using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class Homeloan : Expense
    {
        //Method - Calcuates the monthly repayment money
        public float repayment(float p, float r, float t)
        { 
            float monthlyCost;

        
            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            monthlyCost = (p * r * (float)Math.Pow(1 + r, t)) /(float)(Math.Pow(1 + r, t) - 1);

            return (monthlyCost);


        }

      



    }
}
