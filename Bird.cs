using System;
namespace demo01
{
    public class Bird : Animal
    {
         public Bird(){}
        public Bird(string name, int age):base(name,age, new Fly()){}
        public override void  sayHello(){
            Console.WriteLine("I'm a bird!");
        }
        public void Move(){
            Console.WriteLine(this.Moving.Move());
        }
    }
}