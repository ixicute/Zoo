namespace Zoo
{
    internal class Fox : Wolf
    {
        //Private so only this class has access to the property
        private string PlayTime { get; set; }
        public Fox(string name = "Okänt", string gender = "Okänt", string sound = "Cha cha-cha cha-cha cha-chow!", string type = "Räv", int age = 2)
             : base(name, gender, sound, type, age)
        {
            this.PlayTime = "";
        }

        /// <summary>
        /// Prints out randomized result when playing with animal.
        /// </summary>
        public void Play()
        {
            int temp = rand.Next(1, 4);

            switch (temp)
            {
                case 1:
                    PlayTime = $"{AnimalName} börjar jaga en boll och ser jätteglad ut!";
                    break;
                case 2:
                    PlayTime = $"{AnimalName} Springer mot dig och börjar leka med dina skor!";
                    break;
                case 3:
                    PlayTime = $"{AnimalName} klättrar upp i trädet och börjar tjata:\n" +
                        $"{Sound}";
                    break;
            }

            Console.WriteLine(PlayTime);
        }

        /// <summary>
        /// Prints out randomized result of hunting.
        /// </summary>
        public override void Hunt()
        {
            int temp = rand.Next(1, 4);

            switch (temp)
            {
                case 1:
                    Prey = $"{AnimalName} springer glatt runt och jagar löv.";
                    break;
                case 2:
                    Prey = $"{AnimalName} börjar nosa runt och hittar en blåbärsbuske!";
                    break;
                case 3:
                    Prey = $"{AnimalName} Försvinner en stund och kommer tillbaka med en hare i munnen!";
                    break;
            }

            Console.WriteLine(Prey);

        }
    }
}
