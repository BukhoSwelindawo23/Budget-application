using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal abstract class Expense
    {
        //Declaration
        private int pPrice; 
        private int deposit;
        private int interest;
        private int months;


        
        public int PurPrice {

            //get
            get
            { 
                
                
                return pPrice;
            
       
            }

            //set
            set { pPrice = value; }
        }


        public int Deposit
        {

            //get
            get
            {


                return deposit;


            }

            //set
            set { deposit = value; }
        }

        public int Interest
        {

            //get
            get
            {


                return interest;


            }

            //set
            set { interest = value; }
        }

        public int Months
        {
            get
            {


                return months;


            }
            set { months = value; }
        }





    }
}
