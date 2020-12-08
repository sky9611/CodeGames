/*
 * @lc app=leetcode id=213 lang=csharp
 *
 * [213] House Robber II
 *
 * https://leetcode.com/problems/house-robber-ii/description/
 *
 * algorithms
 * Medium (35.13%)
 * Likes:    916
 * Dislikes: 31
 * Total Accepted:    119.4K
 * Total Submissions: 337.4K
 * Testcase Example:  '[2,3,2]'
 *
 * You are a professional robber planning to rob houses along a street. Each
 * house has a certain amount of money stashed. All houses at this place are
 * arranged in a circle. That means the first house is the neighbor of the last
 * one. Meanwhile, adjacent houses have security system connected and it will
 * automatically contact the police if two adjacent houses were broken into on
 * the same night.
 * 
 * Given a list of non-negative integers representing the amount of money of
 * each house, determine the maximum amount of money you can rob tonight
 * without alerting the police.
 * 
 * Example 1:
 * 
 * 
 * Input: [2,3,2]
 * Output: 3
 * Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money
 * = 2),
 * because they are adjacent houses.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [1,2,3,1]
 * Output: 4
 * Explanation: Rob house 1 (money = 1) and then rob house 3 (money =
 * 3).
 * Total amount you can rob = 1 + 3 = 4.
 * 
 */
public class Solution
{
    public int Rob(int[] nums)
    {
        if(nums.Count()== 0) return 0;
        if(nums.Count() == 1) return nums[0];

        return Math.Max(RobWithoutCirle(nums, 0, nums.Count() - 2), RobWithoutCirle(nums, 1, nums.Count() - 1));
    }

    private int RobWithoutCirle(int[] nums, int start, int end)
    {
        int pre = 0;
        int cur = 0;
        for(int i = start; i <= end; i++)
        {
            int tmp = Math.Max(pre + nums[i], cur);
            pre = cur;
            cur = tmp;
        }

        return cur;
    }
}

