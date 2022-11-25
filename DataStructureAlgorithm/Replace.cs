using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm

{
    public class Replace
    {
        public void ReplaceString()
        {
            string input = "Hello <<name>>, \nWe have your fullname as <<full name>> in our system. \nYour contact number is 91-<<xxxxxxxxxx>>.\nPlease,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            input = input.Replace("<<name>>",name);
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();
            input = input.Replace("<full name>", fullName);
            Console.WriteLine("Enter your Mobile No.");
            string mobile = Console.ReadLine();
            input = input.Replace("<xxxxxxxxxx>", mobile);

            Console.WriteLine(input);
        }
    }
}