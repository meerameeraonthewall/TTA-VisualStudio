using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Drill 1
            Console.WriteLine("DRILL 1");
            string[] objects = { "house", "plant", "fire", "fly", "dog" };
            Console.WriteLine("Enter the name of an object.");
            string word = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = objects[i] + word;
            }

            foreach (string obj in objects)
            {
                Console.WriteLine(obj);
            }
            Console.Read();


            //Drill 2, 3, 4
            Console.WriteLine("DRILL 2, 3, 4");
            for (int j = 0; j < 10; j++)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Infinite Loop");
            }
            Console.Read();
            //Fix to above infinite loop: originally the loop left out j++ so it looped forever; i fixed it by adding j++ to the for loop


            //Drill 5
            Console.WriteLine("DRILL 5");
            for (int k = 0; k <= 10; k++)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(k);
            }


            //Drill 6, 7, 8
            Console.WriteLine("DRILL 6, 7, 8");
            List<string> drill6 = new List <string>() { "one", "two", "three", "four", "five", "six" };

            Console.WriteLine("Enter a word to search for.");
            string w = Convert.ToString(Console.ReadLine());
            bool flag = false;

            for (int l = 0; l < drill6.Count- 1; l++)
            {
                if(drill6[l] == w)
                {
                    flag = true;
                    Console.WriteLine("Your word is located at Index " + l + " in the list.");
                    break;
                }
            }

            if(!flag)
            {
                Console.WriteLine("Your word was not in the list.");
            }


            //Drill 9, 10
            Console.WriteLine("DRILL 9, 10");
            List<string> drill9 = new List<string>() {"John", "Mary", "David", "Claire", "Judith", "John", "Ciara", "Claire", "Kristen", "John", "Maria", "Anna"};
            Console.WriteLine("Enter a name to search for.");
            string name = Convert.ToString(Console.ReadLine());
            List<int> indices = new List<int> ();

            for(int m = 0; m<drill9.Count; m++)
            {
                if(drill9[m] == name)
                {
                    indices.Add(m);
                }
            }

            if (indices.Count == 0)
            {
                Console.WriteLine("That name was not in the list.");
            }
            else
            {
                Console.WriteLine("That name appears at indices: ");
                indices.ForEach(Console.WriteLine);
            }


            //Drill 11
            Console.WriteLine("DRILL 11");
            List<string> drill11 = new List<string>() { "how", "much", "wood", "could", "a", "woodchuck", "chuck", "if", "a", "woodchuck", "could", "chuck", "wood" };
            List<string> bin = new List<string>();

            foreach(string str in drill11)
            {
                System.Threading.Thread.Sleep(500);
                if(bin.Contains(str))
                {
                    Console.WriteLine("'" + str + "' has already appeared!");
                }
                else
                {
                    bin.Add(str);
                    Console.WriteLine("'" + str + "' has not appeared yet.");
                }
            }

            Console.Read();
            
        }
    }
}

