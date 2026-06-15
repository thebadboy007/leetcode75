using System;
using System.Collections.Generic;

public class TwoSumSolution
{
    public static void RunExample()
    {
        int[] nums = { 2, 5, 7, 8, 10 };
        int target = 9;
        int[] result = twoSum(nums, target);
        Console.WriteLine($"Indexes:{result[0]},{result[1]}");
    }

    public static int[] twoSum(int[] nums, int target)
    {
            var numToInsert = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) {
                int complement = target - nums[i];

                if(numToInsert.TryGetValue(complement, out int index))
                {
                    return new int[]{index, i};

                }
                numToInsert[nums[i]] = i;
            }
            throw new ArgumentException("No Two sum solution");
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left<right)
            {
                int currentSum = nums[left] + nums[right];

                if (currentSum < target)
                {
                    left++;
                }
                else if (currentSum > target)
                {
                    right--;
                }
                else
                {
                    return new int[] { left, right };
                }
            }
            return new int[] { -1, -1 };
        }
    }
