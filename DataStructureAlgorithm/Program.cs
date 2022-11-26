using System;
using System.Runtime;

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
                Console.WriteLine("1. Binary Search\n2. Insertion Sorting\n3. Bubble Sort\n4. Anagram\n5. Replace the String using Regex\n6. Ordered List\n7. Unordered List\n8. Balanced Parantheses\n9. Prime Number from Range 0 -1000\n10. Exit");
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
                    case 6:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadTextFile(@"D:\Projects-Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\SortingList.txt");
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        UnorderedList<string> unordered = new UnorderedList<string>();
                        unordered.Add("Add");
                        unordered.Add("Sub");
                        Console.WriteLine("Add & Sub are Successfully Added.");
                        unordered.Display();
                        Console.WriteLine("Sub is going to Delete");
                        unordered.Delete();
                        unordered.Display();
                        break;
                    case 8:
                        BalancedParanthesis balance = new BalancedParanthesis();
                        balance.ReadTextFile(@"D:\Projects-Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BalancedParanthesis.txt");
                        break;
                    case 9:
                        PrimeNumberRange prime = new PrimeNumberRange();
                        prime.PrimeNumber(0,1000);
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