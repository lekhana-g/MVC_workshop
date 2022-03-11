using System;

namespace delg
{
    class Program
    {
        public static int add(int a,int b){
            return a+b;
        }
         public static int mul(int a,int b){
            return a*b;
        }
        public delegate int dadd(int a,int b);
        static void main(string[] args)
        {
            dadd d=new dadd(add);
            dadd d1=new dadd(mul);
            int r=d(10,20);
            int m=d1(90,2);
            System.Console.WriteLine(r);
            System.Console.WriteLine(m);
        }
    }
}
