using System;
namespace JiPP.Zadanie2
{
    public abstract class Animal
    {
        public string Name { get; set; }


        public virtual void Eat(string _nameOfFood)
        {
            Console.WriteLine(Name + " eats: " + _nameOfFood);
        }


    }
}
