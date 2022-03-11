using System;
using AutoMapper;
namespace autom{
    class Program{       
         static void Main(string[] args){
            var config = new MapperConfiguration(cfg =>cfg.CreateMap<Student, StudentDT>()); 
            Student stu = new Student
            {
                Name = "Shivam",
                Age = 20,
                Address = "Bihar",
                Department = "IT"
            }; 
            var mapper = new Mapper(config);
            var stuDT = mapper.Map<StudentDT>(stu);
            Console.WriteLine("Name:" + stuDT.Name + ", Age:" + stuDT.Age + ", Address:" + stuDT.Address + ", Department:" + stuDT.Department);
            Console.ReadLine();
        }
    } 

    public class Student{
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    } 
    public class StudentDT{
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }

}