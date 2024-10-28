using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal
{
    internal class Dog : Animal         // Class Dog inherits from Animal
    {
        public bool GotBone { get; set; } = false;
        public string Bone = "No";
        public string Owner = "Yes";

        public Dog(string name = "Unknown" , string color = "Unknown" , int amountOfLegs = 0 , int age = 0 , bool gotOwner = false , bool gotBone = false ) : base(name, color, amountOfLegs, age, gotOwner)
        {
            GotBone = gotBone;

        }
        public virtual string BoolToString() // To make the bools print Yes or No instead of true or false
        {
            Owner = (GotOwner) ? "No" : "Yes";
            return Owner;
            Bone = (GotBone) ? "No" : "Yes";
            return Bone;

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
        public virtual void GoForAWalk()
        {
            Console.WriteLine("The dog is out on a walk");
        }

        public override string ToString() 
        {
            return $"The dogs name is {Name} \n and the fur is the color {Color}.\n {Name} have {AmountOfLegs} legs.\n Are the age of {Age}. \n Have an owner: {Owner}.\n Have got a bone: {Bone}.\n ";
        }

    }
}
