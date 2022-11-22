using System;
namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 5, 7, 6, 1, 4 };
            Console.WriteLine("Welcome to Data Structure Algorithm");
            BinarySearch binary = new BinarySearch();
            binary.ReadTextFiles(@"D:\Projects-Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt");
            binary.BinarySearchOperation();
        }
    }
}