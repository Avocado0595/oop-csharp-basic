using System;
namespace demo01
{
    public class Cat : Animal
    {
        public Cat(){}
        public Cat(string name, int age):base(name,age){}
        public override void  sayHello(){
            Console.WriteLine("I'm a cat!");
        }
    }
}