using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    public enum DogBreed{
        Mixed,bulldog,Jindo,Yorkshire
    }

   public class Dog :Pet
    {
        
        public DogBreed Breed;

        public Dog(int petId,string name, string color, string gender,DogBreed breed)
            : base(petId, name, color, gender)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()//dog의 고유한 특징
        {
            return "물어 뜯기";
        }

    }
}
