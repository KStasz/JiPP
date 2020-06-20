using System;
namespace JiPP.Zadanie1
{
    public class AStartClass
    {
        public AStartClass()
        {
            Cow cow = new Cow();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            //cow.Eat();
            //horse.Eat();
            //sheep.Eat();

            Feed(cow);
            Feed(horse);
            Feed(sheep);
        }
        private void Feed(Animal animal)
        {
            animal.Eat();
        }
    }
}
