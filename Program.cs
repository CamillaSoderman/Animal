namespace Animal
{
        // Developer:   Camilla Söderman
        // Date:        2024-10-28
        // Class:       .Net24 Fullstack .Net
        // Exercise:    Lab 6 OOP Inheritance
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat("Sotis", "black", 4, 10, true, 9);
            var dog1 = new Dog("Berit", "brown", 3, 5, true, true);
            var dog2 = new Dog(); //Create a dog without specifying information to see the default values.
            var gratedane1 = new GrateDane("Hugo", "white", 4, 3, true, true);
            var snake1 = new Snake("Owen" , "multi color", 0, 7, false, true);
            var cat2 = new Cat();
            
            
            Console.WriteLine(cat1);
            Console.WriteLine(dog1);
            Console.WriteLine(gratedane1);
            Console.WriteLine(snake1);
            Console.WriteLine(dog2);
            cat1.MakeSound();
            cat1.Eat();
            snake1.Eat();
            gratedane1.Eat();
            dog2.Sleep();

            Console.ReadKey();      // Added to have the time to read the output






            
           
        }
    }
}
