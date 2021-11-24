using System;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cat cat1 = new Cat("Tom",2);
            // cat1.sayHello();
            // //cat1.Move();
            // Dog dog1 = new Dog("pug", 3);
            // dog1.sayHello();
            // dog1.Move();

            Animal bird1 = new Bird("b1",5);
            Console.WriteLine(bird1.Moving.Move());
        }
    }
}
