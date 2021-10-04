using System;

namespace LoanCalculator.Core
{
    public class AnnuityLoanPaymentCalculator : ILoanPaymentCalculator
    {
        public (double PaymentAmount, double Debt, double InterestCharge) Calculate(double loanAmount, double interest, int paymentsCount)
        {
            var rateOfInterest = interest / 100 / 12;

            var paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, paymentsCount * -1));

            var interestCharges = rateOfInterest * loanAmount;
            var debt = paymentAmount - interestCharges;
            
            return (paymentAmount, debt, interestCharges);
        }
    }
}