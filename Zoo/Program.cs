using System.Collections;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instances of 5 different animals(classes).
            var wolf = new Wolf(name: "Luna", gender: "Tik", age: 5);
            var lynx = new Lynx(name: "Hunter", gender: "Hane", age: 3);
            var fox = new Fox(name: "Speedy", gender: "Tik");
            var dog = new Dog(name: "Ivar", gender: "Hane", age: 5);
            var eagle = new Eagle(name: "Drake");

            //Adding all previous animals into a list.
            var animals = new List<Animal>() { wolf, lynx, fox, dog, eagle};

            //Looping through all inherited methods
            //within the list and inside of inherited classes.
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].PrintInfo();
                animals[i].MakeSound();
                animals[i].Sleep();
                animals[i].Awake();
                if(i == 0)
                {
                    ((Wolf)animals[i]).Hunt();
                }
                if(i == 1)
                {
                    ((Lynx)animals[i]).Pet();
                }
                
                if(i == 2)
                {
                    ((Fox)animals[i]).Hunt();
                    ((Fox)animals[i]).Play();                                        
                }
                
                if(i == 3)
                {
                    ((Dog)animals[i]).Hunt();
                    ((Dog)animals[i]).Greet();
                }
                if(i == 4)
                {
                    ((Eagle)animals[i]).Fly();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
