using System;
namespace demo01
{
    public class Dog:Animal
    {
        public Dog(string name, int age):base(name, age){}
        public override void sayHello(){
            Console.WriteLine("I'm a dog. My name is "+this.Name);
        }
    }
}