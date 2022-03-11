// //1st question
// using System;
// namespace tasks{
//     class SalesDetails{
//         int TotalAmount;
//         int salesno;
//         int prono;
//         int price;
//         DateTime dateofsale;
//         int qty;
//         public void Sales(int q,int p){
//             this.qty=q;
//             this.price=p;
//             TotalAmount=q*p;
//         }
//         public SalesDetails(){
//             System.Console.WriteLine("Enter salesno,prono,price,dateofsale,qty");
//             salesno=Convert.ToInt32(Console.ReadLine());
//             prono=Convert.ToInt32(Console.ReadLine());
//             price=Convert.ToInt32(Console.ReadLine());
//             dateofsale=Convert.ToDateTime(Console.ReadLine());
//             qty=Convert.ToInt32(Console.ReadLine());
//         }
//         public void DisplayValues(){
//             System.Console.WriteLine("Sales number is "+salesno);
//             System.Console.WriteLine("Product number is "+prono);
//             System.Console.WriteLine("Price is "+price);
//             System.Console.WriteLine("Date of sale is "+dateofsale);
//             System.Console.WriteLine("Quantity is "+qty);
//             System.Console.WriteLine("Total amount is "+TotalAmount);
//         }
//         public static void Main(string[] args){
//             SalesDetails s=new SalesDetails ();
//             s.Sales(s.qty,s.price);
//             s.DisplayValues();

//         }
//   }
// }