using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{


    class SavingCalculator
    {
        private double monthlyDeposit = 0;
        private double interestRate = 0.10;
        private double periodInMonths;
        private double balance  = 0; 
        private double interestEarned = 0;

  

        public void SetMonthlyDeposit(double monthlyDeposit)
        {
            this.monthlyDeposit = monthlyDeposit;
        }

        public void SetPeriod(double periodYears)
        {
            this.periodInMonths = periodYears * 12;
        }


        public double GetAmountPaid()
        {
            return monthlyDeposit * periodInMonths; 
        }


        public double CalculateSaving ()
        {
            for (int i = 0; i < periodInMonths; i++)
            {
                interestEarned = interestRate * balance;
                balance += interestEarned + monthlyDeposit; 
            }

            return balance;
        }


    }
}



