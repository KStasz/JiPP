using System;
using System.Collections.Generic;

namespace JiPP.Zadanie6
{
    public class EStartClass
    {
        public EStartClass()
        {
            List<double> collection = new List<double>();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Wprowadź liczbę nr." + i + ": ");
                double.TryParse(Console.ReadLine(), out double number);
                collection.Add(number);
            }

            Console.WriteLine("Średnia wynosi: " + avg(collection));
            Console.WriteLine("Mediana wynosi: " + median(collection));



        }

        private double median(List<double> collection)
        {
            if (collection.Count % 2 != 0)
            {
                return collection[(collection.Count / 2) + 1];
            }
            else
            {
               return (collection[(collection.Count / 2) - 1] + collection[collection.Count / 2]) / 2;
            }
        }

        private double avg(List<double> locallist)
        {
            double sum = 0;
            foreach (var item in locallist)
            {
                sum += item;
            }
            return sum / locallist.Count;
        }
    }
}
