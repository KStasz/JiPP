using System;
namespace JiPP.Zadanie4
{
    public class Horse : Animal
    {
        public static string EatSomeShit()
        {
            Animal animal = new Horse();
            return animal.Eat();
        }

        public void GiveSound()
        {
            Console.WriteLine("Tak jak robi koń");
        }
    }
}
