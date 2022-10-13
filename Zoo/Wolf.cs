using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Wolf : Animal
    {
        public Wolf(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Sound = "aaaooooooo";
            ID++;
        }
        public string AnimalName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int AnimalID
        {
            get { return ID; }
            set { ID = value; }
        }

    }
}
