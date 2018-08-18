
using System;
using System.Threading;

namespace Events2
{
    public class AnimalHairDresser
    {
        public delegate void AnimalHairDressedEventHandler(object source, EventArgs args);//Defino Delegado
        public event AnimalHairDressedEventHandler AnimalHairDressed;//Defino el evento sobre el Delegado

        public void HairDress(IAnimal animal)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine(animal.Name + " is on the hairdresser");
            System.Console.ForegroundColor = System.ConsoleColor.White;
            Thread.Sleep(2000);
            System.Console.WriteLine(animal.Name + " is being washed");
            Thread.Sleep(2000);
            System.Console.WriteLine(animal.Name + " is being brushed");
            Thread.Sleep(4000);
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine(animal.Name+ " is ready and leaving hairdresser");
            System.Console.ForegroundColor = System.ConsoleColor.White;
            OnAnimalHairDressed();

        }

        protected virtual void OnAnimalHairDressed()
        {
            if (AnimalHairDressed != null)
            {
                AnimalHairDressed(this, EventArgs.Empty);
            }
        }



    }
}
