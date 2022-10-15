namespace Zoo
{
    internal class Wolf : Animal
    {
        //Protected so that inhereted classes also have access to the property.
        protected string Prey { get; set; }
        public Wolf(string name = "Okänt", string gender = "Okänt", string sound = "Morrar", string type = "Varg", int age = 2)
             : base(name, gender, sound, type, age)
        {
            this.Prey = "";
        }

        /// <summary>
        /// Prints out randomized result of hunting.
        /// </summary>
        public virtual void Hunt()
        {
            int temp = rand.Next(1, 4);

            switch (temp)
            {
                case 1:
                    Prey = $"{AnimalName} har fångat en hare!";
                    break;
                case 2:
                    Prey = $"{AnimalName} har fångat en bäver";
                    break;
                case 3:
                    Prey = $"{AnimalName} har lyckats fånga en hjort!";
                    break;
            }

            string howl = $"{AnimalName} börjar tjuta: awwwwooooooooooooo \n" + Prey;

            Console.WriteLine(howl);
        }
    }
}
