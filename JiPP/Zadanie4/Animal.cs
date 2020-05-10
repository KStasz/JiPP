using System;
namespace JiPP.Zadanie4
{
    public interface Animal
    {
        void GiveSound();

        string Eat()
        {
            return "mniam...";
        }
    }
}
