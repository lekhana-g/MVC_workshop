using System;
using BankLibrary;
using System.Collections.Generic;
using BankLibrary.Model;
//using AutoMapper;
namespace assign1
{
    class Program
    {
        //var config = new MapperConfiguration(cfg => {cfg.CreateMap<LekhanaSbacc, LekhanaSbtran>();
        
        static void Main(string[] args)
        {
            BankRepository br=new BankRepository();
             while(true){
              System.Console.WriteLine("---------------");
                System.Console.WriteLine("Choose a number");
                System.Console.WriteLine("1-create a new account");
                System.Console.WriteLine("2.Account details");
                System.Console.WriteLine("3.Deposit money");
                System.Console.WriteLine("4.Withdraw money");
                System.Console.WriteLine("5.Transaction details");
                System.Console.WriteLine("6.Display all accounts");
                System.Console.WriteLine("7.Exit");
                System.Console.WriteLine("Enter the number: ");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch(ch){
                    case 1:
                      LekhanaSbacc s=new LekhanaSbacc();
                      br.NewAccount(s);
                      break;
                    case 2:
                      System.Console.WriteLine("Enter acc number");
                       int acc_number=Convert.ToInt32(Console.ReadLine());
                      try{
                          LekhanaSbacc s1=new LekhanaSbacc();
                          s1=br.GetAccountDetails(acc_number);
                          System.Console.WriteLine("Account details:- ");
                          System.Console.WriteLine("Account number:- "+s1.AccNumber);
                          System.Console.WriteLine("Account holder name:- "+s1.Name);
                          System.Console.WriteLine("Address:- "+s1.Address);
                          System.Console.WriteLine("Balance:- "+s1.Balance);
                      }
                      catch(Exception e){
                          System.Console.WriteLine(e.Message);
                      }
                      break;
                    case 3:
                    try{
                         System.Console.WriteLine("Enter acc number");
                         int ac=Convert.ToInt32(Console.ReadLine());
                         System.Console.WriteLine("Enter the amount to be deposited");
                         int dep=Convert.ToInt32(Console.ReadLine());
                         br.DepositAmount(ac,dep);
                    }
                    catch(Exception e){
                        System.Console.WriteLine(e.Message);
                    }
                     break;

                    case 4:
                    try{
                        System.Console.WriteLine("Enter acc number");
                        int ac1=Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Enter the amount to be withdrawed");
                        int wd=Convert.ToInt32(Console.ReadLine());
                        br.WithdrawAmount(ac1,wd);
                    }
                    catch(Exception e){
                        System.Console.WriteLine(e.Message);
                    }   
                    break;
                    case 5:
                        System.Console.WriteLine("Enter acc no");
                        int ac2=Convert.ToInt32(Console.ReadLine());
                        List<LekhanaSbtran> sbt1=br.GetTransactions(ac2);
                        foreach(LekhanaSbtran lt1 in sbt1){
                                System.Console.WriteLine("--------");
                                System.Console.WriteLine("Transaction id:- "+lt1.TId);
                                System.Console.WriteLine("Transaction type:- "+lt1.TType);
                                System.Console.WriteLine("Account number:- "+lt1.Accno);
                                System.Console.WriteLine("Amount:- "+lt1.Amt);
                                System.Console.WriteLine("Date of transaction:- "+lt1.TDate);
                         }
                         break;
                    case 6:
                      List<LekhanaSbacc> l1=br.GetAllAccounts();
                      foreach(LekhanaSbacc l in l1){
                          System.Console.WriteLine("Acc number:- "+l.AccNumber);
                          System.Console.WriteLine("Name:- "+l.Name);
                          System.Console.WriteLine("Address:- "+l.Address);
                          System.Console.WriteLine("Balance:- "+l.Balance);
                          System.Console.WriteLine("---------");
                      }
                      break;
                    case 7:
                      return;
                    default:
                       System.Console.WriteLine("Enter valid number to perform the operations.");
                       break;    
                }
            }
        }
    
    }
}
