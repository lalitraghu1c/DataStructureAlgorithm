using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BubbleSort
    {
        public void Bubble(int[] binaryArr)
        {
            for (int i = 0; i < binaryArr.Length - 1; i++) // traversing 5 time
            {
                for (int j = 0; j < binaryArr.Length - 1; j++)
                {
                    if (binaryArr[j] > (binaryArr[j + 1])) // > means assending, < means decending & == means the same is needed to be print
                    {
                        int temp = binaryArr[j + 1];
                        binaryArr[j + 1] = binaryArr[j];
                        binaryArr[j] = temp;
                    }
                }
            }
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}