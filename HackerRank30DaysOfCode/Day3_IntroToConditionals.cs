using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        // If N is odd, print Weird
        // If N is even and in the inclusive range of 6 to 20, print Weird
        if (N % 2 != 0 || (N % 2 == 0 && N >= 6 && N <= 20))
        {
            Console.WriteLine("Weird");
        }
        // If N is even and in the inclusive range of 2 to 5, print Not Weird
        // If N is even and greater than 20, print Not Weird
        if (N % 2 == 0 && N >= 2 && N <= 5 || (N % 2 == 0 && N > 20))
        {
            Console.WriteLine("Not Weird");
        }
    }
}