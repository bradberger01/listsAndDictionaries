using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> favFoods = new List<string>() { "pizza", "alfredo", "chicken", "sushi", "broccoli" };
            //Console.WriteLine(favFoods[0]);
            //Console.WriteLine(favFoods[4]);

            //List<string> badFoods = new List<string>();
            ////add in a specific order
            //badFoods[0] = "Onions";
            //badFoods[1] = "Tofu";
            //badFoods[2] = "White Fish";
            //badFoods[3] = "Pigs Feet";

            //List<int> luckyNums = new List<int>();
            //luckyNums.Add(13);
            //luckyNums.Add(8);
            //luckyNums.Add(44);
            //luckyNums.Add(7);

            //List<string> favMovies = new List<string>() { "Fight Club", "Lucky Number Sleven", "Clerks", "Guardians Of The Galaxy" };
            //for (int counter = 0; counter < favMovies.Count; counter++)
            //{
            //    Console.WriteLine(favMovies[counter]);
            //}

            //foreach (string film in favMovies)
            //{
            //    Console.WriteLine(film);
            //}

            //favMovies.Remove("Clerks");

            //foreach (string movingImages in favMovies) 
            //{
            //    Console.WriteLine(movingImages);
            //}

            List<string> animals = new List<string>() { "dog", "cat", "pig", "horse", "human" };
            for (int tally = 0; tally < animals.Count; tally++)
            {
                Console.WriteLine(animals[tally]);
            }

            List<bool> boolList = new List<bool>() { true, false, true, false };
            foreach (bool rain in boolList)
            {
                if(rain == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                 else if (rain != true)
                {
                    Console.WriteLine("No rain toady. Enjoy the sun.");
                }

                Console.WriteLine(rain);
            }

            List<int> randoNumbs = new List<int>();
            randoNumbs[0] = 1;
            randoNumbs[1] = 23;
            randoNumbs[2] = 9;
            randoNumbs[3] = 77;
            randoNumbs[4] = 922;
            randoNumbs[5] = 6;
            randoNumbs[6] = 32;
            randoNumbs[7] = 63;
            randoNumbs[8] = 14;
            randoNumbs[9] = 5;

            bool contains = randoNumbs.Contains(23);
            Console.WriteLine(contains);




                
        


        }
    }
}
