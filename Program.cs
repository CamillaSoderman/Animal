namespace Animal
{
        // Developer:   Camilla Söderman
        // Date:        2024-10-10
        // Class:       .Net24 Fullstack
        // Exercise:    Lab 6 OOP Inheritance
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Sotis", "svart", 4, 10, true, 9);
            Dog dog1 = new Dog("Berit", "brun", 3, 5, true, true);
           // GrateDane gratedane1 = new GrateDane("Hugo", "Vit", 4, 3, true, true);
            Snake snake1 = new Snake("Owen","Melerad", 0, 7, false, true);

            
            gratedane1.Eat();
            Console.WriteLine(cat1);
            Console.WriteLine(dog1);
           Console.WriteLine(gratedane1);
            Console.WriteLine(snake1);
            cat1.MakeSound();
            cat1.Eat();
            snake1.Eat();

            Console.ReadKey();




            // Skriv ut alla djur och make sound mm. och kommentera kod
            // Lägg till default värdet
        }
    }
}
