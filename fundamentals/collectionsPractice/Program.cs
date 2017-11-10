using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArr = {"Tim","Martin", "Nikki", "Sara"};
            
            bool[] boolArr = new bool[10] {true,false,true,false,true,false,true,false,true,false,};

            // int[,] multiArr = new int[10,10];
            // for(int row = 1; row <= 10; row++)
            // {
            //     for(int col = 1; col <= 10; col++)
            //     {
            //         int val = col * row;
            //         multiArr[row - 1, col - 1] = val;
            //     };
            // };

            List<string> icecreams = new List<string>();
            icecreams.Add("Chocolate");
            icecreams.Add("Vanilla");
            icecreams.Add("Strawberry");
            // System.Console.WriteLine(icecreams.Count);
            // System.Console.WriteLine(icecreams[2]);
            // icecreams.RemoveAt(2);
            // System.Console.WriteLine(icecreams.Count);

            Dictionary<string,string> nonsense = new Dictionary<string,string>();
            for(int i = 0; i < nameArr.Length; i++)
            {
                nonsense.Add(nameArr[i], null);
            }
            //For each name key, select a random flavor from the flavor list above and store it as the value
            Random flavor = new Random();
            nonsense["Tim"] = icecreams[flavor.Next(icecreams.Count)];
            nonsense["Martin"] = icecreams[flavor.Next(icecreams.Count)];
            nonsense["Nikki"] = icecreams[flavor.Next(icecreams.Count)];
            nonsense["Sara"] = icecreams[flavor.Next(icecreams.Count)];

            //Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            foreach (var entry in nonsense)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
    }
}
