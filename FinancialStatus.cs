using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class FinancialStatus : Homeloan
    {

        /// <summary>
        ///Calculates the money left.
        /// </summary>
        /// <param name="income"></param>
        /// <param name="tax"></param>
        /// <param name="pPrice"></param>
        /// <param name="deposit"></param>
        /// <param name="interest"></param>
        /// <param name="months"></param>
        /// <returns></returns>
        public int availableMoney(String response, int grossIncome, int taxDeducted, int groceries, int waterAndLights, int travelCosts, int cellPhone, int otherexpen, int monthlyRental, int loan)
        {

            int availableMoney = 0;



            switch (response)
            {
                case "rent":

                    availableMoney = grossIncome - (taxDeducted + groceries + waterAndLights + travelCosts + cellPhone + otherexpen + monthlyRental);

                    break;

                case "buy":

                    availableMoney = grossIncome - (taxDeducted + groceries + waterAndLights + travelCosts + cellPhone + otherexpen + loan);

                    break;

            }

            return availableMoney;








        }
    }
}
