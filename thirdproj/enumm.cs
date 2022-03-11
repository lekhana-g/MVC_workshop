using System;
namespace thridproj{
    class enumm{
        public enum MonthOfYear{
            january=10,feb,mar,apr,may,jun,jul,aug,sep,oct,nuv,dec
        }
        static void main(){
            string[] vals=Enum.GetNames(typeof(MonthOfYear));
            int c=0;
            foreach(string s in vals){
                System.Console.WriteLine(s);
                c++;
            }
            System.Console.WriteLine("count is "+c);

            int[] n=(int[]) Enum.GetValues(typeof(MonthOfYear));
            foreach(int x in n){
                System.Console.WriteLine(x);
            }

        }
    }
}