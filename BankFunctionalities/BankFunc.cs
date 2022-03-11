using System;
using BankLibrary;
using BankLibrary.Model;
using System.Collections.Generic;
namespace BankFunctionalities{
    class BankFunc:IBankFunc{
        BankRepository br=new BankRepository();
        public class AccountNotAvailable:ApplicationException{
        public AccountNotAvailable(string message):base(message){

        }
    }
        public void FundTransfer(int acc1,int acc2,int amt){
            int c1=0,c2=0;
            List<LekhanaSbacc> lb1=br.GetAllAccounts();
            foreach(LekhanaSbacc s in lb1){
                if(s.AccNumber==acc1){
                    c1=1;
                }
                if(s.AccNumber==acc2){
                    c2=1;
                }
                if(c1==1&&c2==1){
                   br.WithdrawAmount(acc1,amt);
                   br.DepositAmount(acc2,amt);
                }
                else{
                    throw new AccountNotAvailable("Please re-check and type valid account numbers to perfrom the transfer.");
                }
                
            }
        }
        public void LoanEligibility(int acc){
              int c1=0;
              List<LekhanaSbacc> lb=new List<LekhanaSbacc>();
              foreach(LekhanaSbacc i in lb){
                  if(i.AccNumber==acc){
                      c1=1;
                      if(i.Balance>1000000){
                          System.Console.WriteLine("Eligible for loan");
                      }
                      else{
                          System.Console.WriteLine("Not eligible for loan");
                      }
                  }
              }
              if(c1==0){
                  throw new AccountNotAvailable("Not a valid account number");
              }
              
        }
    }
}