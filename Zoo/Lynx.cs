namespace Zoo
{
    internal class Lynx : Animal
    {
        //Private so only this class has access to the property
        private string Reaction { get; set; }
        public Lynx(string name = "Okänt", string gender = "Okänt", string sound = "aaaaaAAAAAAAAHHHHHH", string type = "Lodjur", int age = 2)
             : base(name, gender, sound, type, age)
        {
            this.Reaction = "";
        }

        /// <summary>
        /// Prints out a randomized result of petting the animal.
        /// </summary>
        public void Pet()
        {
            int temp = rand.Next(1, 3);

            switch (temp)
            {
                case 1:
                    Reaction = $"{AnimalName} börjar gosa med dig!";
                    break;
                case 2:
                    Reaction = $"{AnimalName} springer iväg och verkar ointresserad.";
                    break;
            }

            Console.WriteLine(Reaction);
        }
    }
}
