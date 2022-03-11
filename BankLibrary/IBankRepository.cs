using System;
using BankLibrary.Model;
namespace BankLibrary{
    interface IBankRepository{
        void NewAccount(LekhanaSbacc acc);
       LekhanaSbacc GetAccountDetails(int accno);
        void DepositAmount(int accno, int amt);
        void WithdrawAmount(int accno, int amt);
    }
}