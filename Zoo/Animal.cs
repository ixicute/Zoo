namespace Zoo
{
    internal abstract class Animal
    {
        //Fileds get "protected"-access to force inheritance and prevent access from outside of class.
        protected string Name;
        protected string Gender;
        protected string Sound;
        protected string Type;
        protected int Age;
        //This field must be static in order to keep the recieved variable from the constructor.
        protected static int ID = 0;

        //Creating an instance of "Random" in order to generate random numbers within methods.
        protected Random rand = new();

        public string AnimalName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string AnimalGender
        {
            get { return Gender; }
            init { Gender = value; }
        }
        public string AnimalSound
        {
            get { return Sound; }
            init { Sound = value; }
        }
        public string AnimalType
        {
            get { return Type; }
            init { Type = value; }
        }
        public int AnimalAge
        {
            get { return Age; }
            set { Age = value; }
        }
        public int AnimalID
        {
            get;
            init;
        }

        protected Animal(string name = "", string gender = "", string sound = "", string type = "Animal", int age = 0)
        {
            this.Name = name;
            this.Gender = gender;
            this.Sound = sound;
            this.Type = type;
            this.Age = age;

            //This property adds 1 to the previus value within the ID-field and updates it's own field with it.
            //This is required to give a number to each created instance of any class that inherits from this one.
            this.AnimalID = ++ID;
        }

        /// <summary>
        /// Method that makes animal sleep.
        /// </summary>
        public virtual void Sleep()
        {
            string sleeping = $"{Name} går och lägger sig.";
            Console.WriteLine(sleeping);
        }

        /// <summary>
        /// Method that wakes up the animal.
        /// </summary>
        public virtual void Awake()
        {
            string awake = $"{Name} är nu vaken!";
            Console.WriteLine(awake);
        }

        /// <summary>
        /// Prints the value of <see cref="Sound"/>.
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        /// <summary>
        /// Method to print out animal information.
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine("[ID: {0}] - [Namn: {1}] - [Typ: {2}] - [Kön: {3}] - [Ålder: {4} år]"
                              ,AnimalID, AnimalName, AnimalType, AnimalGender, AnimalAge);
        }
    }
}
