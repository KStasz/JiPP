using System;
namespace JiPP.Zadanie5
{
    public class DStartClass
    {
        public DStartClass()
        {
            Cow cow = new Cow();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();
            cow.Name = "krowa";
            horse.Name = "koń";
            sheep.Name = "owca";

            Feed(FoodType.Grass, cow, horse, sheep);
            Console.WriteLine();
            Feed(FoodType.Apple, horse);
        }

        private void Feed(FoodType food, params Animal[] animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name + " eats: " + food);
            }
        }
    }
}
