using System;
namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Algorithm");
            BinarySearch binary = new BinarySearch();
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1. Binary Search\n2. Insertion Sorting\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the word you want to Search");
                        binary.ReadTextFiles(@"D:\Projects-Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt");
                        binary.BinarySearchOperation();
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        int[] arr = { 2, 5, 7, 6, 1, 4 };
                        binary.Sort(arr);
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        condition = false;
                        break;
                }
            }
        }
    }
}