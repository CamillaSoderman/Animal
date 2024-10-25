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
        public Snake(string name, string color, int amountOfLegs, int age, bool gotOwner, bool isPoisinous) : base(name, color, amountOfLegs, age, gotOwner)
        {
            IsPoisinous = isPoisinous;

        }
        public string BoolToString() // To make the true or false to print Yes or No
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
            return $"Name: {Name} , Color: {Color} , Legs: {AmountOfLegs} , Age: {Age} , Owner: {Owner} , Poisinous: {IsPoisinous} ";
        }
    }
}
