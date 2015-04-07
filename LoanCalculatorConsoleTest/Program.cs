using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double principalAmount=0;
            double interestRate = 0;
            int noOfMonth = 0;
            double monthlyPayment = 0;

            Console.WriteLine("Enter Principal Amount: ");
            principalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter No Of Month: ");
            noOfMonth = Convert.ToInt32(Console.ReadLine());


            monthlyPayment = principalAmount*((interestRate/noOfMonth)/(1 - Math.Pow((1 + (interestRate/noOfMonth)),noOfMonth)));
            Console.WriteLine(monthlyPayment);
            Console.ReadLine();

        }
    }
}
