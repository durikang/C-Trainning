using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    public class Cat
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Cat(int petId,string name,string color,string gender)
        {
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
            this.PetId = petId;
        }

        public string MakeSound()
        {
            return "야옹";
        }

        public string Scretch()
        {
            return "햘퀴기";
        }

    }
}
