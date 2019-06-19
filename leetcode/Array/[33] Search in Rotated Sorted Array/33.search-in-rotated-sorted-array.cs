/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 *
 * https://leetcode.com/problems/search-in-rotated-sorted-array/description/
 *
 * algorithms
 * Medium (32.70%)
 * Likes:    2445
 * Dislikes: 314
 * Total Accepted:    421K
 * Total Submissions: 1.3M
 * Testcase Example:  '[4,5,6,7,0,1,2]\n0'
 *
 * Suppose an array sorted in ascending order is rotated at some pivot unknown
 * to you beforehand.
 * 
 * (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
 * 
 * You are given a target value to search. If found in the array return its
 * index, otherwise return -1.
 * 
 * You may assume no duplicate exists in the array.
 * 
 * Your algorithm's runtime complexity must be in the order of O(log n).
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [4,5,6,7,0,1,2], target = 0
 * Output: 4
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [4,5,6,7,0,1,2], target = 3
 * Output: -1
 * 
 */
public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums.Count() == 0)
            return -1;
        // for(int i = 0; i< nums.Count() - 1; i++)
        // {
        //     if (nums[i] > nums[i + 1])
        //     {
        //         if (target >= nums[0])
        //             return BinarySearch(nums, 0, i, target);
        //         else
        //             return BinarySearch(nums, i + 1, nums.Count() - 1, target);
        //     }
        // }

        int start = 0;
        int end = nums.Count() - 1;
        int pivot = 0;
        while(start < end)
        {
            pivot = (end + start) / 2;
            if (nums[pivot] > nums[end])
                start = pivot + 1;
            else
                end = pivot;
        }

        // Console.WriteLine(pivot);

        pivot = start;
        if(pivot == 0)
            return BinarySearch(nums, 0, nums.Count() - 1, target);
        if(nums[pivot - 1] < target )
            return -1;
        if(nums[0] <= target )
            return BinarySearch(nums, 0, pivot - 1, target);

        return BinarySearch(nums, pivot, nums.Count() - 1, target);
    }

    public int BinarySearch(int[] nums, int start, int end, int target)
    {
        if (start == end && target != nums[start])
            return -1;

        if(nums[(end+start)/2] == target)
            return (end+start)/2;

        if(nums[(end+start)/2] > target)
            return BinarySearch(nums, start, (end+start)/2, target);
        else
            return BinarySearch(nums, (end+start)/2 + 1, end, target);
    }
}

