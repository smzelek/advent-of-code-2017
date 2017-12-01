using System;
using System.Linq;
using System.IO;

class InverseCaptcha
{
    static void Main()
    {
        // foreach (string line in File.ReadLines("Input1.txt"))
        // {
        //     Console.WriteLine(GetAdjacentMatchingSum(line));
        // }

        foreach (string line in File.ReadLines("Input2.txt"))
        {
            Console.WriteLine(GetHalfwayAheadMatchSum(line));
        }
    }

    static int GetAdjacentMatchingSum (string s)
    {
        int[] nums = s.Select(n => Convert.ToInt32(n.ToString())).ToArray();
        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == nums[(i + 1) % nums.Length])
            {
                sum += nums[i];
            }
        }
        return sum;
    }

    static int GetHalfwayAheadMatchSum (string s) {
        int[] nums = s.Select(n => Convert.ToInt32(n.ToString())).ToArray();
        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == nums[(i + nums.Length/2) % nums.Length])
            {
                sum += nums[i];
            }
        }
        return sum;
    }
}