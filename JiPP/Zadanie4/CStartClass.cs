using System;
namespace JiPP.Zadanie4
{
    public class CStartClass
    {
        public CStartClass()
        {
            Console.WriteLine(Cow.EatSome());
            Cow cow = new Cow();
            cow.GiveSound();

            Console.WriteLine(Cow.EatSome());
            Console.WriteLine();

            Console.WriteLine(Horse.EatSome());
            Horse horse = new Horse();
            horse.GiveSound();
        }
    }
}
