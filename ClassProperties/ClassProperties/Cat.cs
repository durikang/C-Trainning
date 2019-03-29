using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    public class Cat : Pet
    {
       

        public Cat(int petId,string name,string color,string gender)
            :base(petId,name,color,gender)
        {
            

        }

        public override string MakeSound()
        {
            return "야옹";
        }

        public string Scretch()//펫의 고유한 특징
        {
            return "햘퀴기";
        }

    }
}
