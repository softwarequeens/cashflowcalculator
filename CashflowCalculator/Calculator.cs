using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashflowCalculator
{
    class Calculator
    {
        private int amount, duration, r, numOfMonth, remainBal;

        public static int MonthlyPayment(int amount, int duration, int r)
        {
            int MonthlyPay = amount * (r / 1200) / (1 - (1 + r / 1200) ^ (-duration*12));
            return MonthlyPay;
        }
        public static int InterestCalc(int amount, int r, int remainBal)
        {
            int InterestPayment = remainBal * r / 1200;
            return InterestPayment;
        }
        public static int PrincipalPay(int MonthlyPay, int InterestPayment)
        {
            int PrincipalPay = MonthlyPay - InterestPayment;
            return PrincipalPay;
        }

    }
}
