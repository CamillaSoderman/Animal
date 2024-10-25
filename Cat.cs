using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat : Animal
    {
        public int? LivesLeft { get; set; } = 9;
        private string Owner = "Yes";
        public Cat(string name, string color, int amountOfLegs, int age, bool gotOwner, int livesLeft) : base(name, color, amountOfLegs, age, gotOwner)
        {
            LivesLeft = livesLeft;

        }


        public string BoolToString() // To make the true or false to print Yes or No
        {
            Owner = (GotOwner) ? "No" : "Yes";
            return Owner;

        }

        public override void MakeSound()
        {
            Console.WriteLine("The cat says 'Mjau'");
        }
        public override void Eat()
        {
            Console.WriteLine("The cat is palying with the food");

        }

        public override void Sleep()
        {
            Console.WriteLine("The cat is sleeping");
        }

        public virtual void ClimbTree()
        {
            Console.WriteLine("The cat is at the top of the tree!");
        }

        public override string ToString() 
        {
            return $"Name: {Name} , Color: {Color} , Legs: {AmountOfLegs} , Age: {Age} , Owner: {Owner} , Lives: {LivesLeft} ";
        }

    }
}
