using System;
namespace demo01
{
    public class Animal
    {
        public string Name{get; set;}
        public int Age{get; set;}

        public Animal(){}
        public Animal(string name, int age){
            this.Name = name;
            this.Age = age;
        }  

        public void sayHello(){
            Console.WriteLine("Hello");
        }

    }
}