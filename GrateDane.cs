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
        
        public GrateDane(string name, string color, int amountOfLegs, int age, bool gotOwner, bool gotBone)  : base(name, color, amountOfLegs, age, gotOwner, gotBone)
        {


        }

        public string BoolToString() // To make the true or false to print Yes or No
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
            return $"Name: {Name} , Color: {Color} , Legs: {AmountOfLegs} , Age: {Age} , Owner: {Owner} , Bone: {Bone} , Breed: {Breed } ";
        }
    }
}
