using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Snake : Animal
    {
        public bool IsPoisinous { get; set; } = false;
        private string Owner = "Yes";
        private string Poison = "No";
        public Snake(string name = "Unknown", string color = "Unknown", int amountOfLegs = 0 , int age = 0 , bool gotOwner = false , bool isPoisinous = false ) : base(name, color, amountOfLegs, age, gotOwner)
        {
            IsPoisinous = isPoisinous;

        }
        public string BoolToString() // To make the bools print Yes or No instead of true or false
        {
            Owner = (GotOwner) ? "No" : "Yes";
            return Owner;
            Poison = (IsPoisinous) ? "No" : "Yes";
            return Poison;

        }
        public override void MakeSound()
        {
            Console.WriteLine("The Snake shakes its tale to make a sound");
        }
        public override void Eat()
        {
            Console.WriteLine("The snake is eating a rat");

        }

        public override void Sleep()
        {
            Console.WriteLine("The snake is sleeping");
        }

        public virtual void Attack()
        {
            Console.WriteLine("The snake have poisoned you!");
        }
        public override string ToString() 
        {
            return $"The dogs name is {Name} \n and the fur is the color {Color}.\n {Name} have {AmountOfLegs} legs.\n Are the age of {Age}. \n Have an owner: {Owner}.\n Are poisinous: {Poison}.\n ";
        }
    }
}
