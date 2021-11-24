using System;
namespace demo01
{
    public class Dog:Animal
    {

        public Dog(string name, int age):base(name, age, new Run()){}
        public override void sayHello(){
            Console.WriteLine("I'm a dog. My name is "+this.Name);
        }
        public void Move(){
           Console.WriteLine(this.Moving.Move());
        }
        
    }
}