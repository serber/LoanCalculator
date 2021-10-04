namespace LoanCalculator.Core
{
    public interface ILoanPaymentCalculator
    {
        (double PaymentAmount, double Debt, double InterestCharge) Calculate(double loanAmount, double interest, int paymentsCount);
    }
}