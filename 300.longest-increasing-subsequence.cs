/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 *
 * https://leetcode.com/problems/longest-increasing-subsequence/description/
 *
 * algorithms
 * Medium (40.34%)
 * Likes:    2654
 * Dislikes: 60
 * Total Accepted:    234.3K
 * Total Submissions: 570.8K
 * Testcase Example:  '[10,9,2,5,3,7,101,18]'
 *
 * Given an unsorted array of integers, find the length of longest increasing
 * subsequence.
 * 
 * Example:
 * 
 * 
 * Input: [10,9,2,5,3,7,101,18]
 * Output: 4 
 * Explanation: The longest increasing subsequence is [2,3,7,101], therefore
 * the length is 4. 
 * 
 * Note: 
 * 
 * 
 * There may be more than one LIS combination, it is only necessary for you to
 * return the length.
 * Your algorithm should run in O(n^2) complexity.
 * 
 * 
 * Follow up: Could you improve it to O(n log n) time complexity?
 * 
 */
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        if(nums.Count() == 0) return 0;
        List<int> list = new List<int>();
        list.Add(nums[0]);
        for(int i = 1; i < nums.Length; i++)
        {
            if(list[list.Count() - 1] < nums[i])
                list.Add(nums[i]);
            else
                list[BinarySearch(list, nums[i])] = nums[i];
        }
        return list.Count();
    }

    public int BinarySearch(List<int> list, int target)
    {
        int start = 0;
        int end = list.Count() - 1;
        while(start <= end)
        {
            int mid = (start + end) / 2;
            if(list[mid] < target)
                start = mid + 1;
            else if(list[mid] > target)
                end = mid-1;
            else
                return mid;
        }
        return start;
    }
}

