using System.Collections.Generic;
namespace firstmvcproj.Models{
    public class Emp{
        public int eid{get;set;}
        public string name{get;set;}
        public float salary{get;set;}
        public Emp(){

        }
        public Emp(int id,string ename,float sal){
            eid=id;
            name=ename;
            salary=sal;
        }
        public static List<Emp> GetEmployees(){
            List<Emp> emp1=new List<Emp>();
            emp1.Add(new Emp(1,"lekhana",50000));
            emp1.Add(new Emp(2,"phani",70000));
            return emp1;
        }
    }
}