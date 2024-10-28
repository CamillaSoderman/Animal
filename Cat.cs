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
        public Cat(string name = "Unknown" , string color = "Unknown" , int amountOfLegs = 0 , int age = 0 , bool gotOwner = false , int livesLeft = 9 ) : base(name, color, amountOfLegs, age, gotOwner)
        {
            LivesLeft = livesLeft;

        }


        public string BoolToString() // To make the bools print Yes or No instead of true or false
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
            return $"The cats name is {Name} \n and the fur is the color {Color}.\n {Name} have {AmountOfLegs} legs.\n Are the age of {Age}. \n Have an owner: {Owner}.\n  Lives left: {LivesLeft}. \n";
        }

    }
}
