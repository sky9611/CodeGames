/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 *
 * https://leetcode.com/problems/jump-game-ii/description/
 *
 * algorithms
 * Hard (27.64%)
 * Total Accepted:    160.4K
 * Total Submissions: 578.6K
 * Testcase Example:  '[2,3,1,1,4]'
 *
 * Given an array of non-negative integers, you are initially positioned at the
 * first index of the array.
 * 
 * Each element in the array represents your maximum jump length at that
 * position.
 * 
 * Your goal is to reach the last index in the minimum number of jumps.
 * 
 * Example:
 * 
 * 
 * Input: [2,3,1,1,4]
 * Output: 2
 * Explanation: The minimum number of jumps to reach the last index is 2.
 * ⁠   Jump 1 step from index 0 to 1, then 3 steps to the last index.
 * 
 * Note:
 * 
 * You can assume that you can always reach the last index.
 * 
 */
public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1)
                return 0;
        
        for(int i = 0, curMax = 0, nextMax = 0, jumps = 0; i < nums.Length; ++i) {
            nextMax = Math.Max(nextMax, i + nums[i]);
            if (nextMax >= nums.Length - 1)
                return ++jumps;
            
            if (i == curMax) {
                ++jumps;
                curMax = nextMax;
            }
        }
        return -1;
    }
}
