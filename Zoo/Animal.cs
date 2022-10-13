using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        protected string Name;
        protected string Gender;
        protected string Sound; //predator or prey
        protected int Age;
        protected static int ID;

        public virtual string Sleep()
        {
            string sleeping = $"{Name} is now sleeping!";
            return sleeping;
        }

        public virtual string Awake()
        {
            string awake = $"{Name} is now awake!";
            return awake;
        }

        public virtual string MakeSound()
        {
            string animalSound = Sound;
            return Sound;
        }
    }
}
