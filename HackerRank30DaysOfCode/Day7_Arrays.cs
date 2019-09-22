using System;

class Solution
{



    static void Main(string[] args)
    {
        //Size of array
        int n = Convert.ToInt32(Console.ReadLine());

        //fill the array
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        //reverse the array
        Array.Reverse(arr);

        //print the array
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

