using System;
namespace JiPP.Zadanie4
{
    public class Cow : Animal
    {
        public static string EatSomeShit()
        {
            Animal animal = new Cow();
            return animal.Eat();
        }

        public void GiveSound()
        {
            Console.WriteLine("Muuuu....");
        }

    }
}
