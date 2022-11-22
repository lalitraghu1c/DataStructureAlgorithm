using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BinarySearch
    {
        string[] binaryArr;
        public void ReadTextFiles(string filePath)
        {
            string words = File.ReadAllText(filePath);
            binaryArr = words.Split(",");
        }
        public void BinarySearchOperation()
        {
            string input = Console.ReadLine().ToLower();
            foreach (var words in binaryArr)
            {
                if (words.Equals(input))
                {
                    Console.WriteLine("{0} - Yupiee, Found the word in the list using binary search");
                    return;
                }
            }
            Console.WriteLine("Searched element is not available in the lsit of words");

        }
        public void Display()
        {
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}