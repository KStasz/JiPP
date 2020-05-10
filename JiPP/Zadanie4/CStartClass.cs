using System;
namespace JiPP.Zadanie4
{
    public class CStartClass
    {
        public CStartClass()
        {
            Console.WriteLine(Cow.EatSomeShit());
            Cow cow = new Cow();
            cow.GiveSound();

            Console.WriteLine(Cow.EatSomeShit());
            Console.WriteLine();

            Console.WriteLine(Horse.EatSomeShit());
            Horse horse = new Horse();
            horse.GiveSound();
        }
    }
}
