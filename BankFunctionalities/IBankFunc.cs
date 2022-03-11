using System;
namespace BankFunctionalities{
    interface IBankFunc{
        void LoanEligibility(int accno);
        void FundTransfer(int accno1,int accno2,int amt);
    }
}