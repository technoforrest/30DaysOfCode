/**
 * Input Format

The first line contains an integer that you must sum with i.
The second line contains a double that you must sum with d.
The third line contains a string that you must concatenate with s.

Output Format

Print the sum of both integers on the first line, the sum of both
doubles (scaled to 1 decimal place) on the second line, and then
the two concatenated strings on the third line.**/

using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank30Days_1
{
    class Solution
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2 = "";
            string userInput = "";
            // Read and save an integer, double, and String to your variables.
            userInput = Console.ReadLine();
            i2 = Convert.ToInt32(userInput);
            userInput = Console.ReadLine();
            d2 = Convert.ToDouble(userInput);
            userInput = Console.ReadLine();
            s2 = userInput;

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(String.Format("{0:0.0}", d + d2));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
