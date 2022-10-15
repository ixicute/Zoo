namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //skapar instanser av 5 olika djur.
            var wolf = new Wolf(name: "Luna", gender: "Tik", age: 5);
            var lynx = new Lynx(name: "Hunter", gender: "Hane", age: 3);
            var fox = new Fox(name: "Speedy", gender: "Tik");
            var dog = new Dog(name: "Ivar", gender: "Hane", age: 5);
            var eagle = new Eagle(name: "Drake");

            //Printing all methods available for each animal.
            wolf.PrintInfo();
            wolf.MakeSound();
            wolf.Sleep();
            wolf.Awake();
            wolf.Hunt();

            Console.WriteLine("--------------------------------");
            lynx.PrintInfo();
            lynx.MakeSound();
            lynx.Sleep();
            lynx.Awake();
            lynx.Pet();

            Console.WriteLine("--------------------------------");
            fox.PrintInfo();
            fox.MakeSound();
            fox.Sleep();
            fox.Awake();
            fox.Play();
            fox.Hunt();

            Console.WriteLine("--------------------------------");
            dog.PrintInfo();
            dog.MakeSound();
            dog.Sleep();
            dog.Awake();
            dog.Hunt();
            dog.Greet();

            Console.WriteLine("--------------------------------");
            eagle.PrintInfo();
            eagle.MakeSound();
            eagle.Sleep();
            eagle.Awake();
            eagle.Fly();

            Console.ReadKey();
        }
    }
}