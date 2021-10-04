using LoanCalculator.Core;
using System;

namespace LoanCalculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var loanAmount = 4200000.00;
            var interest = 7.69;
            var paymentsCount = 300;

            var calculator = new AnnuityLoanPaymentCalculator();
            var interestChargesTotal = 0.00;

            for(var i = paymentsCount; i > 0; i--)
            {
                var (paymentAmount, debt, interestCharge) = calculator.Calculate(loanAmount, interest, i);

                if (paymentAmount <= 0)
                {
                    break;
                }

                loanAmount -= debt;                
                loanAmount -= 60000;

                interestChargesTotal += interestCharge;

                Console.WriteLine($"#{paymentsCount - i + 1} Payment amount = {paymentAmount}, Debt = {debt}, Interest charge = {interestCharge}, Loan = {loanAmount}");
            }
        }
    }
}