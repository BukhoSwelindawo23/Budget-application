using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    class Program
    {
        delegate void myDel(string str);

        static void Main(string[] args)
        {
            int moneyLeft = 0;
            Vehicle car = new Vehicle();
            Homeloan obj = new Homeloan();   // Creating object from the class Homeloan
            FinancialStatus obj2 = new FinancialStatus(); // Creating object from the class FinancialStatus

            Dictionary<string, int> expenselist = new Dictionary<string, int>(); //generic collection to store the expenses

            Console.WriteLine("************************************************************************************************");
            Console.WriteLine("Welcome, Please enter your name");
            String  user = Console.ReadLine();
            Console.WriteLine("************************************************************************************************");

            //Try - Will excute the code.
            try
            {

                Console.WriteLine("Enter your monthly income "+ user);
                int income = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */



                Console.WriteLine("Enter Tax deduction "+ user);
                int tax = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Estimated monthly tax deducted", tax);  //Adding to list

                Console.WriteLine("Estimated monthly expenditures in each of the following categories");
          
                Console.WriteLine("Enter how much you spend on Groceries");
                int groceries = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Groceries", groceries);

                Console.WriteLine("Enter how much you spend on Water and lights");
                int waterAndLights = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Water and lights", waterAndLights);

                Console.WriteLine("Enter how much you spend on Travel costs (including petrol)");
                int travelCosts = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Travel costs (including petrol)", travelCosts);

                Console.WriteLine("Enter how much you spend on Cell phone and telephone");
                int cellPhone = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Cell phone and telephone", cellPhone);

                Console.WriteLine("Enter how much you spend on Other expenses");
                int otherexpen = Convert.ToInt32(Console.ReadLine()); /* Converts to integer type */
                expenselist.Add("Other expenses", otherexpen);



                /*
                  Loops while respone is not buy or rent, use do-while loop.
                 */
                String response;
                do { 
                    Console.WriteLine("Do you want to rent or buy property "+user+ "? Enter rent or buy");
                        response = Console.ReadLine();  // stores user input  

                } while (response != "rent" && response != "buy");


                //Declaring rent amount and loan repayment
                int rentAmount = 0;
                int loanRepayment = 0;

                if (response == "rent")
                {

                    Console.WriteLine("Enter rent amount ");
                    rentAmount = Convert.ToInt32(Console.ReadLine());  /* Converts to integer type */
                    expenselist.Add("Monthly rental amount", rentAmount);


                   

                }


                else if (response == "buy")
                {
                    Console.WriteLine("Enter purchase price of the house");
                    int pPrice = Convert.ToInt32(Console.ReadLine());  /* Converts to integer type */

                    Console.WriteLine("Enter the deposit");
                    int deposit = Convert.ToInt32(Console.ReadLine());  /* Converts to integer type */

                    Console.WriteLine("Enter the interest ");
                    int interest = Convert.ToInt32(Console.ReadLine());  /* Converts to integer type */

                    Console.WriteLine("Enter total months to repay loan (between 240 and 360 ");
                    int months = Convert.ToInt32(Console.ReadLine());   /* Converts to integer type */

                    loanRepayment = (int)obj.repayment(pPrice - deposit, interest, months);


                    /*Condition - if the monthyly home loan is more than third of income to the 
                     income alert is sent to the user.
                    */
                    if (loanRepayment > (income / 3))
                    {

                        Console.WriteLine("Approval of homeloan is unlikely");

                    }
                    else
                    {
                        Console.WriteLine("Home-loan is likely to be approved");
                    }

                    expenselist.Add("Home Loan repayment", loanRepayment);

                }
                        
                 moneyLeft = obj2.availableMoney(response, income, tax, groceries, waterAndLights, travelCosts, cellPhone, otherexpen, rentAmount, loanRepayment);  //Calling object, diaplays value of the money available

                Console.WriteLine("   ");
                Console.WriteLine("================================================================================");
                Console.WriteLine("Available monthly money after all the specified deductions have been made: "+ moneyLeft);
         
                

                //returns the cost of buying a car
                int carCost = car.monthlyCost();

                if (carCost > 0)
                {
                    expenselist.Add("Vehicle EMI", carCost);
                }


                int totalExpense = 0;
                if (response == "rent")
                {
                    totalExpense = tax + groceries + waterAndLights + travelCosts + cellPhone + rentAmount + otherexpen + carCost;
                }
                else if (response == "buy")
                {
                    totalExpense = tax + groceries + waterAndLights + travelCosts + cellPhone + otherexpen + loanRepayment + carCost;
                }
                if (totalExpense > (income * 3 / 4))
                {

                    myDel del3 = delegate (string name ) {
                        Console.WriteLine("Total expenses are greater than 75 percent of gross income");
                    };
                }
                int count = 0;
                Console.WriteLine("   ");
                Console.WriteLine("===================================================================================================");
                //Display the expenses to the user in descending order by value
                Console.WriteLine("Expenses, in descending order by value:");
                foreach (KeyValuePair<string, int> i in expenselist.OrderByDescending(key => key.Value))
                {

                    count++;
                    Console.WriteLine(count+") "+i.Key +" >>> "+ i.Value);
                }
               


            }
            //catching the exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
