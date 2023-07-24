using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COnAppAssignment14
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
         
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                        
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        static bool IsSorted(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                    return false;
            }
            return true;
        }
        public static void print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("\n");
        }
 
       
       
        static void Main(string[] args)
        {
            int[] arr1 = { 45,67,98,23,56,87,65,43,87};
            int[] arr2 = { 45, 67, 98, 23, 56, 87, 65, 43, 87 };
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Print without Bubble Sort");
            print(arr1);
            stopwatch.Start();
            BubbleSort(arr1);
            stopwatch.Stop();
            Console.WriteLine("After Bubble Sort");
            print(arr1);
            Console.WriteLine($"array sorted or not :\t{IsSorted(arr1)}");
            Console.WriteLine($"Time taken to sort {arr1.Length} in bubble sort: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");


            Console.WriteLine("Before insertion sort");
            print(arr2);
           
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            InsertionSort(arr2);
            stopwatch2.Stop();
            Console.WriteLine("After insertion Sort Array");
            print(arr2);
            Console.WriteLine($"array sorted or not :\t {IsSorted(arr2)}");
            Console.WriteLine($"Time taken to sort {arr2.Length}in insertion sort: {stopwatch2.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}