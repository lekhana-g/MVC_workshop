// using System;

// namespace thirdproj
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a=Convert.ToInt32(Console.ReadLine());
//             int b=Convert.ToInt32(Console.ReadLine());
//             try{
//                 int c=a/b;
//                 Console.WriteLine(c);
//             }
//             catch(FormatException){
//                 System.Console.WriteLine("check the format");
//             }
//             catch(Exception e){
//                 System.Console.WriteLine(e.Message);
//             }
//         }
//     }
// }


 // System.Console.WriteLine("Enter 1 to deposit,2 to withdraw");
            // int sw=Convert.ToInt32(Console.ReadLine());
            // switch(sw){
            //     case 1:
            //         System.Console.WriteLine("Enter the amount to be deposited");
            //         //int.TryParse(Console.ReadLine(),out dep);
            //         int dep=Convert.ToInt32(Console.ReadLine());
            //         b.DepositAmount(s.acc_number,dep,s);
            //         break;
            //     case 2:
            //         try{
            //         System.Console.WriteLine("Enter the amount to be withdrawed");
            //         int wd=Convert.ToInt32(Console.ReadLine());
            //         b.WithdrawAmount(s.acc_number,wd,s);
            //         }
            //         catch(WithdrawbalanceException e){
            //         System.Console.WriteLine(e.Message);
            //         }
            //         break;
            //     case default:
            //         System.Console.WriteLine("Enter a number between 1 & 2");
            // }