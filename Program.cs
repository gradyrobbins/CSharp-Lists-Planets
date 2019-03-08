using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // foreach (string planet in planetList)
            //     {
            //     Console.WriteLine(planet);
            //     }

            List<string> newplanetList = new List<string>(){"Uranus", "Neptune"};
                Console.WriteLine("Added 2 new planets");

            foreach (string planet in newplanetList)
                {
                Console.WriteLine(planet);
                }

            planetList.AddRange(newplanetList);

                Console.WriteLine("use AddRange() to add 2 more planets");

            foreach (string planet in planetList)
                {
                Console.WriteLine(planet);
                }

            Console.WriteLine("use Insert() to add 2 more planets");
            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");

            foreach (string planet in planetList)
            {Console.WriteLine(planet);}

            planetList.Add("Pluto");
            Console.WriteLine("Add pluto");
            Console.WriteLine("");

            foreach (string planet in planetList)
            {Console.WriteLine(planet);}

             Console.WriteLine("\noutput = planetList.GetRange(2, 3).ToArray()");
                string[] rockyPlanets = planetList.GetRange(0, 4).ToArray();

            Console.WriteLine();
                // Console.WriteLine("Rocky Planets:");
            foreach( string planet in rockyPlanets )
            {
                Console.WriteLine($"Rocky Planet: {planet}");
            }

            planetList.Remove("Pluto");
            {Console.WriteLine();}
            {Console.WriteLine("Remove Pluto");}

            foreach (string planet in planetList)
            {Console.WriteLine(planet);}




            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
            };

            // Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            for(int i = 0; i <= numbers.Count -1 ; i++){
                if(numbers.Contains(i)){
                    Console.WriteLine($"Numbers list has {i}");
                } else {
                    Console.WriteLine($"{numbers[i]} sucks");
                }
            }

            // Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.


        }



        }
    }

