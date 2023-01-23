using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace AlgorithmProgram
{
    internal class Program
    {
        public static object Permutations { get; private set; }
        public static object BinarySearch { get; private set; }
        public static object BubbleSort { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Permutation Using Recursion");
                Console.WriteLine("3.Binary Search the word from wordlist");
                Console.WriteLine("4.Insertion Sort");
                Console.WriteLine("5.Bubble Sort");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutations.Permutate(str, 0, n - 1);
                        break;
                    case 2:
                        string txtpath = File.ReadAllText(@"C:\Users\Radhika\source\repos\AlgorithmPrograms1\ListOfWords.txt");
                        List<string> words = new List<string>(txtpath.Split(" "));
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;
                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);
                        break;
                    case 4:
                        int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;

                    default:
                        Console.WriteLine("Enter the valid option!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }






        }


    }
    }
    
