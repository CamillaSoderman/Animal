using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class GrateDane : Dog
    {
        public string? Breed = "Grate Dane";

        public GrateDane(string name = "Unknown" , string color = "Unknown" , int amountOfLegs = 0 , int age = 0 , bool gotOwner = false , bool gotBone = false) : base(name, color, amountOfLegs, age, gotOwner, gotBone)
        {


        }

        public override string BoolToString() // To make the bools print Yes or No instead of true or false
        {
            return base.BoolToString();

        }

        public override void MakeSound()
        {
            Console.WriteLine($"The dog goes: 'Voff' ");
        }

        public override void Eat()
        {
            Console.WriteLine("The dog is eating");

        }

        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping");
        }
        public override void GoForAWalk()
        {
            Console.WriteLine("The Grate Dane is out on a walk");
        }
        public override string ToString() 
        {
            return $"The dogs name is {Name} \n and the fur is the color {Color}.\n {Name} have {AmountOfLegs} legs.\n Are the age of {Age}. \n Have an owner: {Owner}.\n Have got a bone: {Bone}.\n And is a {Breed }.\n";
        }
    }
}
