// //12th question
// using System;
// namespace tasks{
//     abstract class Student{
//         public abstract Boolean IsPassed(int score);
//     }
//     class Undergraduate:Student{
//         public override bool IsPassed(int score)
//         {

//            if(score>70){
//                return true;
//            }
//            return false;

//         }
//     }
//     class Graduate:Student{
//         public override bool IsPassed(int score)
//         {
//             if(score>80){
//                 return true;
//             }
//             return false;
//         }
//     }
//     class Grades{
//         static void Main(){
//             Undergraduate u=new Undergraduate();
//            System.Console.WriteLine(u.IsPassed(75)); 
//             Graduate g=new Graduate();
//             Console.WriteLine(g.IsPassed(95));
//         }
//     }
    
// }
