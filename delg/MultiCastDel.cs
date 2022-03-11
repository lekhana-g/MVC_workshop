using System;
using System.Text;
using System.IO;
namespace delg{
class MultiCastDel{
    public delegate void pmessage(string s);
    public static void ConsoleP(string msg){
        System.Console.WriteLine(msg);
    }
    public static void ConsoleF(string msg){
         FileStream m=new FileStream("deg.txt",FileMode.Append,FileAccess.Write);
         StreamWriter s=new StreamWriter(m);
         s.WriteLine(msg);
         s.Flush();
         m.Close();
    }
    public static void Main(){
        pmessage p1=new pmessage(ConsoleP);
        pmessage p2=new pmessage(ConsoleF);
        pmessage p3=p1=p2;
        System.Console.WriteLine("Enter string");
        string data=Console.ReadLine();
        p3(data);
    }
}
}