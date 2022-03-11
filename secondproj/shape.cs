// using System;
// namespace secondproj{
//     class shape{
//         string color;
//         protected float area;
//          //int age;
//         public virtual void AcceptDetails(){
//             System.Console.WriteLine("Enter color: ");
//             color=Console.ReadLine();
//         }
//         public virtual void DisplayDetails(){
//             System.Console.WriteLine(color);
//         }
//         public abstract void calcarea(){
            
//         }
//         //  public int Age{
//         //      get{return age;}
//         //      set{
//         //          if(value>0){
//         //              age=value;
//         //          }
//         //          else{
//         //              age=0;
//         //          }
//         //      }
//         //  }
//     }
//     class rectangle:shape{
//         int l,b;
//         public override void AcceptDetails(){
//             base.AcceptDetails();
//             System.Console.WriteLine("Enter l and b");
//             l=Convert.ToInt32(Console.ReadLine());
//             b=Convert.ToInt32(Console.ReadLine());

//         }
//         public override void calcarea(){
//             area=l*b;
//         }
//         public override void DisplayDetails()
//         {
//             base.DisplayDetails();
//             System.Console.WriteLine(area);
//         }
//     }
//     class circle:shape{
//         int radius;
//         double area;
//                 public override void AcceptDetails()
//         {
//             base.AcceptDetails();
//             System.Console.WriteLine("Enter radius");
//             radius=Convert.ToInt32(Console.ReadLine());
//         }
//         public override void calcarea(){
//             area=3.14*radius*radius;
//         }
//         public override void DisplayDetails(){
//             base.DisplayDetails();
//             System.Console.WriteLine(area);
//         }
//     }

// }