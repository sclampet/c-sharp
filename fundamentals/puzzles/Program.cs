using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static Array RandomArray()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int min = arr[0];
            int max = 0;
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
                sum += arr[i];
                if(i == 0)
                {
                    min = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
            return arr;
        }
        public static String TossCoin()
        {
            System.Console.WriteLine("Tossing Coin!");
            Random rand = new Random();
            int flipped = rand.Next(1,100);
            string result = "";
            if(flipped % 2 == 0)
            {
                System.Console.WriteLine("Heads");
                result = "Heads";
            } else
            {
                System.Console.WriteLine("Tails");
                result = "Tails";
            }
            return result;
        }
        public static Double TossMultipleCoins(int num)
        {
            int totalHeads = 0;
            for(int i = 1; i < num + 1; i++)
            {
                string thisToss;
                thisToss = TossCoin();
                if(thisToss == "Heads")
                {
                    totalHeads += 1;
                }
            }
            double ratio = totalHeads/num;
            System.Console.WriteLine(totalHeads);
            System.Console.WriteLine($"Ratio: {ratio}");
            return ratio;
        }
        public static Array Names()
        {
            string[] people = new string[] {"Todd", "TIffany", "Charlie", "Geneva", "Sydney"};
            int idx;
            string temp;
            Random rand = new Random();

            for (int i = 0; i < people.Length; i++)
            {
                idx = rand.Next(people.Length);

                temp = people[i];
                people[i] = people[idx];
                people[idx] = temp;
            }

            List<string> longNames = new List<string>();
            for(int i = 0; i < people.Length; i++)
            {
                if(people[i].Length > 5)
                {
                    longNames.Add(people[i]);
                }
            }
            string[] newArr = new string[longNames.Count];
            for(int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = longNames[i];
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(300);
            // Names();
        }
    }
}
