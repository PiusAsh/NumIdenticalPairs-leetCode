using System;

namespace GoodPairs
{

    class Program
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            int result = NumIdenticalPairs(nums);
            Console.WriteLine(result);
        }
    }
}
