using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting C#! Great job!");

            HashSet<string> Showroom = new HashSet<string>();

            Showroom.Add("2017 Porsche 911");
            Showroom.Add("2017 Limbourghini Aventador");
            Showroom.Add("2017 Bugatti Veyron");
            Showroom.Add("2017 Tesla Model S");

            int numCars = Showroom.Count;

            foreach (string thing in Showroom)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine($"There are {numCars} cars in our car lot");
            Console.WriteLine(" ");

            Showroom.Add("2017 Tesla Model S");


            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("1957 Porsche 911");
            UsedLot.Add("2016 Koenigsegg CCXR Trevita");

            Showroom.UnionWith(UsedLot);
            
            foreach (string thing in Showroom)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine(" ");

            Showroom.Remove("2017 Tesla Model S");

            foreach (string thing in Showroom)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine(" ");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("1957 Porsche 911");
            Junkyard.Add("1963 Porsche 911");
            Junkyard.Add("1977 Porsche 911");
            Junkyard.Add("2005 Porsche 911");
            Junkyard.Add("2017 Porsche 911");

            foreach (string thing in Junkyard)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine(" ");

            // 2. Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.

            // Showroom.IntersectWith(Junkyard);

            // 3. Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.

            Showroom.UnionWith(Junkyard);

            foreach (string thing in Showroom)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine(" ");

            // 4. Use the Remove() method to remove any cars that you acquired from the junkyard that you want in your showroom.

            Showroom.Remove("1977 Porsche 911");

            foreach (string thing in Showroom)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine(" ");
        }
    }
}
