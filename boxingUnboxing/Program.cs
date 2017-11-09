using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> test = new List<object>();
            test.Add(7);
            test.Add(28);
            test.Add(-1);
            test.Add(true);
            test.Add("chair");
            int total = 0;
            foreach(var entry in test)
            {
                // System.Console.WriteLine(entry);
                if(entry is int)
                {
                    total = (int)entry + total;
                }
            }
            System.Console.WriteLine("total: " + total);
        }

        
    }
}
