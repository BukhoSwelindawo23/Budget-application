using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class Vehicle
    {
       

        public int monthlyCost()
        {
            Homeloan calculate = new Homeloan();


            /* Used this formula A = P(1 + i*n) 
            * I manipulated the formula it to P = A/(1+i*n)
            * P = monthly cost
            * A = Price of the vehicle
            * i = interest
            * n = months
            
            * Since the program has to include insurance and total deposit. 
            * i add them to the equation
            */

            Console.WriteLine("Want to buy a vehicle, select 1 or 2");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");
            int totalCost = 0;
            int selectvehicle = Convert.ToInt32(Console.ReadLine());
            if (selectvehicle == 1)
            {
                Console.WriteLine("Enter Model and make");
                string make = Console.ReadLine();

                Console.WriteLine("Enter Purchase price");
                int carPrice = 0;
                carPrice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Total deposit");
                int totalDeposit = 0;
                totalDeposit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Interest rate (percentage)");
                int interestRate = 0;
                interestRate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Estimated insurance premium");
                int estInsPremium = 0;
                estInsPremium = Convert.ToInt32(Console.ReadLine());

                totalCost =  (int)calculate.repayment(carPrice - totalDeposit + estInsPremium, interestRate, 5);
            }
            return totalCost;
        }





           

      

       
        }

    }


