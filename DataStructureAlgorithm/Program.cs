using System;
namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Algorithm");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1. Binary Search\n2. Insertion Sorting\n3. Bubble Sort\n4. Anagram\n5. Replace the String using Regex\n6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the word you want to Search");
                        BinarySearch binary = new BinarySearch();
                        binary.ReadTextFiles(@"D:\Projects-Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt");
                        binary.BinarySearchOperation();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        BinarySearch binary1 = new BinarySearch();
                        Console.WriteLine("\n");
                        int[] arr = { 2, 5, 7, 6, 1, 4 };
                        binary1.Sort(arr);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        int[] arr1 = { 8,3,5,8,8,1,4,3,9,2 };
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Bubble(arr1);
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("heart" , "earth");
                        break;
                    case 5:
                        Replace replace = new Replace();
                        replace.ReplaceString();
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