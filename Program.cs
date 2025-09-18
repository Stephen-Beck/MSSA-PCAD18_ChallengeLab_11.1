/*
LeetCode #75. Sort Colors

public class Solution {
    public void SortColors(int[] nums) {
        
    }
}
*/

/*
Given an array nums with n objects colored red, white, or blue, 
sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

**You must solve this problem without using the library's sort function.**

    Example 1:
        Input: nums = [2,0,2,1,1,0]
        Output: [0,0,1,1,2,2]

    Example 2:
        Input: nums = [2,0,1]
        Output: [0,1,2] 
*/

namespace ChallengeLab_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] {2, 0, 1};
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");


            // custom test cases
            nums = new int[] { 1, 0, 2, 1, 0, 2, 1, 0 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] { 2, 2, 1, 0, 0, 1, 2, 0, 1 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] { 0, 1, 1, 0, 2, 2, 0, 1, 2, 0 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] { 1, 1, 1, 1, 1 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] { 0, 0, 0, 1, 1, 2, 2, 2 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");

            nums = new int[] { 2, 2, 1, 1, 0, 0 };
            Console.WriteLine($"Input: nums = [{String.Join(',', nums)}]");
            SortColors(nums);
            Console.WriteLine($"Output: [{String.Join(',', nums)}]\n");
        }

        static void SortColors(int[] nums)
        {
            // Since we are only working with three colors (numbers),
            // we can move all 0s to the left and 2s to the right, this would leave 1s in the middle
            // If there were more than three colors (numbers), I'd likely use a merge sort or something similar

            int zeroToHere = 0; // set to left side of array
            int twoToHere = nums.Length - 1; // set to right side of array
            int i = 0; // set current index in array

            // Iterate through the array until we hit twoToHere, since we know everything to the right of that is already a 2
            while (i <= twoToHere)
            {
                switch (nums[i])
                {
                    case 0:
                        int temp = nums[zeroToHere]; // put zeroToHere into temp variable
                        nums[zeroToHere] = 0; // set zeroToHere to 0 (could also make this nums[i], which we already know is 0)
                        nums[i] = temp; // set nums[i] to temp, effectively swapping nums[zeroToHere] and nums[i]
                        zeroToHere++; // move zeroToHere to the right one index
                        i++; // move forward in the array
                        break;
                    case 1:
                        i++; // move forward in the array
                        break;
                    case 2:
                        temp = nums[twoToHere]; // put twoToHere into temp variable
                        nums[twoToHere] = 2; // set twoToHere to 2 (could also make this nums[i], which we already know is 2)
                        nums[i] = temp; // set nums[i] to temp, effectively swapping nums[twoToHere] and nums[i]
                        twoToHere--; // move twoToHere to the left one index
                        // DO NOT move forward in the array (this is where I was going wrong in my debugging other test cases I added!)
                        break;
                }
            }
        }
    }
}