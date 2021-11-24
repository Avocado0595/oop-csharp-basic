using System;
namespace demo01
{
    public class Animal
    {
        private string name;
        private int age;

        public Animal(){}
        public Animal(string name, int age){
            this.name = name;
            this.age = age;
        }
        public void setName(string name){
            this.name = name;
        }
        public string getName(){
            return this.name;
        }

        public void sayHello(){
            Console.WriteLine("Hello");
        }

    }
}