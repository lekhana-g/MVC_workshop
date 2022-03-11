// //20th question
// using System;
// namespace tasks{
//     interface MyInterface{

//         void CalcCon(int a,int t);
//     }
//     class library:MyInterface{
//         public void CalcCon(int a,int t){
//             if(a<=5){
//                 Console.WriteLine("Little champs - free ticket");
//             }
//             else if(a>60){
//                 int con=Convert.ToInt32(0.3*t);
//                 int ff=t-con;
//                 System.Console.WriteLine("Senior citizen "+ff);
//             }
//             else{
//                 System.Console.WriteLine("Ticket booked "+t);
//         }

//         }
//     }
//     class Program{
//         public static void Main(string[] args){
//             System.Console.WriteLine("Enter name and age");
//             string name=Console.ReadLine();
//             int age=Convert.ToInt32(Console.ReadLine());
//             int t=600;
//             MyInterface M;
//             M=new library();
//             M.CalcCon(age,t);
//         }
//     }
// }