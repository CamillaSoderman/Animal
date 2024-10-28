using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        // 5 egenskaper
        public string Name { get; set; } = "Unknown";       // You can set a name but if you dont, "Unknown" will be written out
        public string Color { get; set; } = "Unknown";
        public int AmountOfLegs { get; set; } = 4;
        public int Age { get; set; } = 1;
        public bool GotOwner { get; set; } = true;

        public Animal(string name , string color, int amountOfLegs, int age, bool gotOwner) // Constructor that create the animal
        {
            Name         = name;
            Color        = color;
            AmountOfLegs = amountOfLegs;
            Age          = age;
            GotOwner     = gotOwner;

        }
        public virtual void MakeSound()     // Method that gets override in subclasses
        { 
        }
        public virtual void Eat()           // Method that gets override in subclasses
        {

        }
        public virtual void Sleep()         // Method that gets override in subclasses
        {

        }
        public override string ToString()   // Method that helps print out the animal in string
        {
            return $"{ Name } , { Color } , { AmountOfLegs } , { Age } , { GotOwner }";
        }
    }
}
