/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 *
 * https://leetcode.com/problems/maximum-product-subarray/description/
 *
 * algorithms
 * Medium (28.68%)
 * Likes:    2184
 * Dislikes: 103
 * Total Accepted:    218.6K
 * Total Submissions: 741.6K
 * Testcase Example:  '[2,3,-2,4]'
 *
 * Given an integer array nums, find the contiguous subarray within an array
 * (containing at least one number) which has the largest product.
 * 
 * Example 1:
 * 
 * 
 * Input: [2,3,-2,4]
 * Output: 6
 * Explanation: [2,3] has the largest product 6.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [-2,0,-1]
 * Output: 0
 * Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
 * 
 */
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Count() == 0) return 0;
        int max = nums[0];
        int min = nums[0];
        int res = nums[0];
        for (int i = 1; i < nums.Count(); i++)
        {
            int cur = nums[i];

            int a = cur * min;
            int b = cur * max;

            max = Math.Max(cur, Math.Max(a, b));
            min = Math.Min(cur, Math.Min(a, b));
            res = Math.Max(max, res);
        }

        return res;
    }
}

