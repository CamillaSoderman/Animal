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
    internal class Dog : Animal
    {
        public bool GotBone { get; set; } = false;
        public string Bone = "No";
        public string Owner = "Yes";

        public Dog(string name, string color, int amountOfLegs, int age, bool gotOwner, bool gotBone) : base(name, color, amountOfLegs, age, gotOwner)
        {
            GotBone = gotBone;

        }
        public string BoolToString() // To make the true or false to print Yes or No
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
            return $"Name: {Name} , Color: {Color} , Legs: {AmountOfLegs} , Age: {Age} , Owner: {GotOwner} , Bone: {Bone} ";
        }

    }
}
