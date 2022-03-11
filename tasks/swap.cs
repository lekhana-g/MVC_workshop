// //10th question
// using System;
// namespace tasks{
//     class swap{
//         public void swap1(int a,int b){
//             int temp=a;
//             a=b;
//             b=temp;
//             System.Console.WriteLine("Values after swapping "+a+" "+b);
//         }
//         public void swap1(string a,string b){
//             a=a+b;
//             b=a.Substring(0,a.Length-b.Length);
//             a=a.Substring(b.Length);
//             System.Console.WriteLine("After swap "+a+" "+b);

//         }
//         static void Main(){
//                swap s=new swap();
//                s.swap1(10,2);
//                s.swap1("fare","portal");
//         }
//     }
// }