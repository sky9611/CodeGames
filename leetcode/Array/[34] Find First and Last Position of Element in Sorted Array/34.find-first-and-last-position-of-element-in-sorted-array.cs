/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 *
 * https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
 *
 * algorithms
 * Medium (33.09%)
 * Likes:    1591
 * Dislikes: 87
 * Total Accepted:    305.7K
 * Total Submissions: 909.1K
 * Testcase Example:  '[5,7,7,8,8,10]\n8'
 *
 * Given an array of integers nums sorted in ascending order, find the starting
 * and ending position of a given target value.
 * 
 * Your algorithm's runtime complexity must be in the order of O(log n).
 * 
 * If the target is not found in the array, return [-1, -1].
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [5,7,7,8,8,10], target = 8
 * Output: [3,4]
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [5,7,7,8,8,10], target = 6
 * Output: [-1,-1]
 * 
 */
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Count() == 0)
            return new int[]{-1, -1};
        int[] res= new int[2];
        int start = 0;
        int end = nums.Length - 1;
        int a = -1;
        while(start < end)
        {
            int mid = (end + start) / 2;
            if (nums[mid] < target)
            {
                start = mid+1;
            }
            else if (nums[mid] >= target)
            {
                end = mid;
            }
        }

        if(nums[start] == target)
            res[0] = start;
        else
            return new int[]{-1, -1};

        end = nums.Length - 1;
        
        while(start < end)
        {
            int mid = (end + start) / 2;
            if (nums[mid] == target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
        }

        if(nums[start] == target)
            res[1] = start;
        else
            res[1] = start - 1;

        return res;

        // int start = FirstAppearLocation(nums, target, 0);
        // if (start == nums.Length || nums[start]!=target)
        //     return new int[]{-1, -1};
        // else
        //     return new int[]{start, FirstAppearLocation(nums, target+1, start)-1};
    }

    // public int FirstAppearLocation(int[] nums, int target, int start)
    // {
    //     int low = start;
    //     int high = nums.Length;
    //     while(low < high)
    //     {
    //         int mid = (low + high) / 2;
    //         if(nums[mid] < target)
    //             low = mid + 1;
    //         else
    //             high = mid;
    //     }
    //     return low;
    // }
}

