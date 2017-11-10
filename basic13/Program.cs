using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // print1To255();
            // printOdd1To255();
            // printSum1To255();
            int[] numArr = new int[] {1,-2,3,4,-10};
            // iterateArr(numArr);
            // maxValue(numArr);
            // avgArr(numArr);
            // oddArr();
            // greaterThanY(numArr, 0);
            // squareValues(numArr);
            // replaceNegatives(numArr);
            // minMaxAvg(numArr);
            // shiftValues(numArr);
            object[] x = {-1,2,3,-4,-6,5,6,7};
            numToString(x);


        }
        public static void print1To255()
        {
            for(int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void printOdd1To255()
        {
            for (int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void printSum1To255()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void iterateArr(int[] numArr)
        {
            for(int i = 0; i < numArr.Length; i++)
            {
                System.Console.WriteLine(numArr[i]);
            }
        }
        public static void maxValue(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine($"Max: {max}");
        }
        public static void avgArr(int[] arr)
        {
            int total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            int avg = total / arr.Length;
            System.Console.WriteLine($"Average: {avg}");
        }
        public static void oddArr()
        {
            int[] oddArr = new int[256];
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    oddArr[i] = i;
                }
            }
            System.Console.WriteLine(oddArr);
        }
        public static void greaterThanY(int[] arr, int num)
        {
            int total = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > num)
                {
                    total += 1;
                }
            }
            System.Console.WriteLine($"Total: {total}");
        }
        public static void squareValues(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void replaceNegatives(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void minMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int total = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                total += arr[i];
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int avg = total / arr.Length;
            System.Console.WriteLine($"Min: {min} Max: {max} Avg: {avg}");
        }
        public static void shiftValues(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int endOfArr = arr.Length - 1;
                if(i == endOfArr)
                {
                    arr[i] = 0;
                } else
                {
                    arr[i] = arr[i + 1];
                    System.Console.WriteLine(arr[i]);
                }
            }
        }
        public static void numToString(object[] arr)
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                if((int)arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
