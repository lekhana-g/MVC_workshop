using System;
using System.Collections.Generic;
using BankLibrary.Model;
namespace BankLibrary{
    public class BankRepository:IBankRepository{
        DatabaseTrainingContext db=new DatabaseTrainingContext();
        Random r=new Random();
        public void NewAccount(LekhanaSbacc acc){
             System.Console.WriteLine("Enter account number: ");
            int an=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter name");
            string n=Console.ReadLine();
            System.Console.WriteLine("Enter address");
            string a=Console.ReadLine();
             System.Console.WriteLine("Enter balance");
            int b=Convert.ToInt32(Console.ReadLine());
            acc.AccNumber=an;
            acc.Address=a;
            acc.Name=n;
            acc.Balance=b;
            db.LekhanaSbaccs.Add(acc);
            db.SaveChanges();
            System.Console.WriteLine("--new account is created--");
        }
        public  class WithdrawbalanceException:ApplicationException{
        public WithdrawbalanceException(string message):base(message){
        }
    }
      public class negativeNumber:ApplicationException{
            public negativeNumber(string message):base(message){

            }
        }
        public class AccountNotAvailable:ApplicationException{
        public AccountNotAvailable(string message):base(message){

        }
    }
        public LekhanaSbacc GetAccountDetails(int accno)
        {
            Boolean af=false;
            LekhanaSbacc ls=new LekhanaSbacc();
            foreach(LekhanaSbacc l in db.LekhanaSbaccs){
                if(l.AccNumber==accno){
                    af=true;
                    ls=l;
                    break;
                }
            }
            if(af==true){
                return ls;
            }
            else{
                throw new AccountNotAvailable("Account number is not found");
            }
        }
        public List<LekhanaSbacc> GetAllAccounts()
        {
            List<LekhanaSbacc> sbas=new List<LekhanaSbacc>();
            foreach(LekhanaSbacc s in db.LekhanaSbaccs){
                sbas.Add(s);
            }
            System.Console.WriteLine("Details fetched!");
            return sbas;
        }

        public List<LekhanaSbtran> GetTransactions(int accno)
        {
            List<LekhanaSbtran> t1=new List<LekhanaSbtran>();
            foreach(LekhanaSbtran st in db.LekhanaSbtrans){
                if(st.Accno==accno){
                    t1.Add(st);
                }
            }
            return t1;
        }
    
        public void DepositAmount(int accno, int amt)
        {
            LekhanaSbtran lt1=new LekhanaSbtran();
            Boolean af=false;
            foreach(LekhanaSbacc s in db.LekhanaSbaccs){
                if(s.AccNumber==accno){
                    if(amt>=0){
                        af=true;
                        s.Balance+=amt;
                        System.Console.WriteLine("amount of {0} deposited successfully in account number {1}",amt,s.AccNumber);
                        System.Console.WriteLine(" Updated balance is "+s.Balance);
                    }
                    else{
                        throw new negativeNumber("Negative value cannot be taken as a deposit");
                    }
                }
            }
            if(af==true){
                lt1.Accno=accno;
                lt1.Amt=amt;
                lt1.TType="deposit";
                lt1.TId=r.Next(0,100);
                lt1.TDate=DateTime.Now;
                db.LekhanaSbtrans.Add(lt1);
                db.SaveChanges();
            }
            else{
                System.Console.WriteLine("account not found");
            }
            
       }
 
        public void WithdrawAmount(int accno,int amt){
            LekhanaSbtran lt1=new LekhanaSbtran();
            Boolean af=false;
            foreach(LekhanaSbacc s in db.LekhanaSbaccs){
                if(s.AccNumber==accno){
                    af=true;
                    if(s.Balance>amt){
                        s.Balance-=amt;
                        System.Console.WriteLine("ammount of {0} has been debited from your account successfully",amt);
                        System.Console.WriteLine("current balance in your account is {0}",s.Balance);  
                    }
                    else if(amt>s.Balance){
                        throw new WithdrawbalanceException("Insufficient funds to perform the withdrawal");
                    }
                    else if(amt<0){
                        throw new negativeNumber("Negative value cannot be taken in withdrawal");
                    }
                    break;
                }
            }
            if(af==true){
                lt1.Accno=accno;
                lt1.TId=r.Next(100,200);
                lt1.TDate=DateTime.Today;
                lt1.Amt=amt;
                lt1.TType="withdrawl";
                db.LekhanaSbtrans.Add(lt1);
                db.SaveChanges();
            }
            else{
                throw new AccountNotAvailable("Account not found");
            }
            
        }
    }
}