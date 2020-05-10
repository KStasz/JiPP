using System;
namespace JiPP.Zadanie2
{
    public class BStartClass
    {
        public BStartClass()
        {
            Cow cow = new Cow();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();

            cow.Name = "krowa";
            horse.Name = "koń";
            sheep.Name = "owca";

            feed("grass", cow, horse, sheep);
            feed("apple", horse);
        }


        private void feed(string _nameOfFood, params Animal[] animals)
        {
            foreach (var item in animals)
            {
                item.Eat(_nameOfFood);
            }
        }
    }
}
