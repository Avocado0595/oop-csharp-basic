using System;
namespace demo01
{
    public abstract class Animal
    {
        public string Name{get; set;}
        public int Age{get; set;}
        public IMove Moving {get; set;}
        public Animal(){}
        public Animal(string name, int age, IMove moving){
            this.Name = name;
            this.Age = age;
            this.Moving = moving;
        }  

        public abstract void sayHello();

    }
}