namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolfie = new Wolf("Henrik", "Hane", 5);
            Wolf wolfie2 = new Wolf("Johan", "Hane", 5);
            Wolf wolfie3 = new Wolf("Anders", "Hane", 5);
            Console.WriteLine(wolfie.MakeSound());
            Console.WriteLine(wolfie.AnimalID + " " + wolfie2.AnimalID + " " + wolfie3.AnimalID);
            //Wolf wolfie2 = new Wolf();
            //Console.WriteLine(wolfie2.AnimalID);
        }
    }
}