// //9th question
// using System;
// struct Books{
//     private int book_id;
//     private string title;
//     private string author;
//     private string subject;
//     public void GetValues(){
//         Console.WriteLine("Enter id,title,author,subject");
//         book_id=Convert.ToInt32(Console.ReadLine());
//         title=Console.ReadLine();
//         author=Console.ReadLine();
//         subject=Console.ReadLine();
//     }
//     public void ShowValue(){
//         System.Console.WriteLine("Book id: "+book_id);
//         System.Console.WriteLine("Title: "+title);
//         System.Console.WriteLine("Author: "+author);
//         System.Console.WriteLine("Subject: "+subject);
//     }
// }
// class TestStructures{
//     static void Main(){
//         Books b=new Books();
//         b.GetValues();
//         b.ShowValue();
//     }
// }