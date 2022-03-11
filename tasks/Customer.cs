// //2nd question
// using System;
// namespace Customer{
//     class Customer{
//         int cid;
//         string name;
//         int age;
//         int phone;
//         string city;
//         public Customer(){}
//         public Customer(int c,string n,int a,int p,string ci){
//             this.cid=c;this.name=n;this.age=a;this.phone=p;this.city=ci;
         
//         }

//         public void Details(){
//             System.Console.WriteLine("Enter details: ");
//              cid=Convert.ToInt32(Console.ReadLine());
//             name=Console.ReadLine();
//             age=Convert.ToInt32(Console.ReadLine());
//             phone=Convert.ToInt32(Console.ReadLine());
//             city=Console.ReadLine();
//         }
//         public void DisplayData(){
//             System.Console.WriteLine("Customer id "+cid);
//             System.Console.WriteLine("Name is "+name);
//             System.Console.WriteLine("Age is "+age);
//             System.Console.WriteLine("Contact "+phone);
//             System.Console.WriteLine("City "+city);
//         }
//         ~Customer(){
//             System.Console.WriteLine("Destroyed");
//         }
//         static void Main(){
//             Customer cc=new Customer();
//             cc.Details();
//             cc.DisplayData();
//             GC.Collect();
//         }
//     }
// }