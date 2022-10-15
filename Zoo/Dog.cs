namespace Zoo
{
    internal class Dog : Wolf
    {
        //Private so only this class has access to the property
        private bool Happy { get; set; }
        public Dog(string name = "Okänt", string gender = "okänt",string sound = "WOOF WOOF.... woof", string type = "Hund", int age = 2)
             : base(name, gender, sound, type, age)
        {
            this.Happy = false;
        }

        /// <summary>
        /// Prints out a greeting message when interacting with Dog.
        /// </summary>
        public void Greet()
        {            
            Happy = true;
            while (Happy)
            {
                Console.WriteLine("Hunden börjar vifta med svansen och kommer springande mot dig!\n" +
                                  "Hunden blir jätteglad men sedan går och sätter sig.");
                Happy = false;
            }
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
                    Prey = $"{AnimalName} hittar ett sten och börjar skälla på den!";
                    break;
                case 2:
                    Prey = $"{AnimalName} hittar en bransch och kommer springande mot dig med den!";
                    break;
                case 3:
                    Prey = $"{AnimalName} börjar skälla på den flygande örnen!";
                    break;
            }

            Console.WriteLine(Prey);

        }
    }
}
