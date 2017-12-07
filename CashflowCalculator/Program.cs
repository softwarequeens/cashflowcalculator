using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashflowCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in your loan amount: ");
            string amount1 = Console.ReadLine();
            float amount = Int32.Parse(amount1);
            Console.WriteLine(string.Format("You entered {0}", amount));

            Console.Write("Please enter in your loan duration: ");
            string duration1 = Console.ReadLine();
            int duration = Int32.Parse(duration1);
            Console.WriteLine(string.Format("You entered {0}", duration));

            Console.Write("Please enter in your interest rate: ");
            string r1 = Console.ReadLine();
            float r = float.Parse(r1);
            Console.WriteLine(string.Format("You entered {0}", r));

            int ind = 1;
            int numOfMonth = 0;
            int principal = 0;
            int remainBal = amount - principal;
            while (ind>0)
            {
                numOfMonth++;
                int interestPay = Calculator.InterestCalc(amount, r, remainBal);
                int principalPay = Calculator.PrincipalPay(remainBal,interestPay);
                remainBal  = remainBal - interestPay;
                Console.WriteLine(numOfMonth + " " + interestPay + " " + principalPay + " " + remainBal);
                Console.Write("Would you want to calculate for next month? Enter Yes or No");
                string conti = Console.ReadLine();
                if (conti.Equals("Yes")) {ind = 1;}
                else { ind = 0; }
            }

        }
    }
}
