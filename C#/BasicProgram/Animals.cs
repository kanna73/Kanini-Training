using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Animals:Sound,AnimalType
    {
        string name;
        int eyes, mouth, legs, tail;

        public string Name { get => name; set => name = value; }
        public int Eyes { get => eyes; set => eyes = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Legs { get => legs; set => legs = value; }
        public int Tail { get => tail; set => tail = value; }

        public Animals(string name,int eyes,int mouth,int legs,int tail)
        {
            this.Name = name;
            this.Eyes = eyes;
            this.Mouth = mouth;
            this.Legs = legs;
            this.Tail= tail;
        }
        public void MakeSound(string name)
        {
            if (name == "dog")
                Console.WriteLine("Bow bow");
            else if (name == "cat")
                Console.WriteLine("Meow meow");
        }

        public void Type(string name)
        {
            if (name == "dog")
                Console.WriteLine("Carnivore");
            else if (name == "cow")
                Console.WriteLine("Herbivores");

        }

    }
}
