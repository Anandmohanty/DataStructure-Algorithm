namespace AlgorithmProgram
{
    internal class Program
    {
        public static object BinarySearch { get; private set; }
        public static object Permutations { get; private set; }

        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Algorithm Programs!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Permutation Using Recursion");
                Console.WriteLine("3.Binary Search the word from wordlist");
                Console.WriteLine("4.Insertion Sort");
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
                        BinarySearch.Equals(words);
                        break;
                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
        insertionSort.PrintArray(arr);
                        insertionSort.PrintArray(arr);
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