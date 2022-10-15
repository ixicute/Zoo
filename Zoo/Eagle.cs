namespace Zoo
{
    internal class Eagle : Animal
    {
        //Private so only this class has access to the property
        private string FlyResult { get; set; }
        public Eagle(string name = "Okänt", string gender = "Okänt", string sound = "Beeeeee-aaaaaaaaaq", string type = "Örn", int age = 2)
             : base(name, gender, sound, type, age)
        {
            this.FlyResult = "";
        }

        /// <summary>
        /// Prints out randomized results whether the eagle flies or not.
        /// </summary>
        public void Fly()
        {
            int temp = rand.Next(1, 3);
            switch (temp)
            {
                case 1:
                    FlyResult = $"{AnimalName} börjar flyga iväg. \n" +
                                $"{AnimalName} kommer tillbaka med en hare!";
                    break;
                case 2:
                    FlyResult = $"{AnimalName} vägrar flyga.";
                    break;
            }
            Console.WriteLine(FlyResult);
        }
    }
}
