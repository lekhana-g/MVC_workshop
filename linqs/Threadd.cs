using System;
using System.Threading;
class Threadd{
    static void WriteY(){
        for(int i=0;i<900;i++){
            System.Console.Write("y");
        }
    }
    static void Main(){
        Thread t=new Thread(WriteY);
        t.Start();
        Thread.Sleep(10);
        for(int i=0;i<1000;i++){
            System.Console.Write("x");
        }
        

    }
}