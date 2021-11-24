using System;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Jerry",1);
            animal1.sayHello();
            Cat cat1 = new Cat("Tom",2);
            cat1.sayHello();

        }
    }
}
