using System;
namespace secondproj{
    class Casio : ICalculator
    {
        public void mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void sub(int a, int b)
        {
            throw new NotImplementedException();
        }

        void add(int a,int b){
            System.Console.WriteLine(a+b);
        }

        void ICalculator.add(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}