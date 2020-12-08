/*
 * @lc app=leetcode id=416 lang=csharp
 *
 * [416] Partition Equal Subset Sum
 *
 * https://leetcode.com/problems/partition-equal-subset-sum/description/
 *
 * algorithms
 * Medium (40.02%)
 * Likes:    1306
 * Dislikes: 37
 * Total Accepted:    93.3K
 * Total Submissions: 227.6K
 * Testcase Example:  '[1,5,11,5]'
 *
 * Given a non-empty array containing only positive integers, find if the array
 * can be partitioned into two subsets such that the sum of elements in both
 * subsets is equal.
 * 
 * Note:
 * 
 * 
 * Each of the array element will not exceed 100.
 * The array size will not exceed 200.
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: [1, 5, 11, 5]
 * 
 * Output: true
 * 
 * Explanation: The array can be partitioned as [1, 5, 5] and [11].
 * 
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [1, 2, 3, 5]
 * 
 * Output: false
 * 
 * Explanation: The array cannot be partitioned into equal sum subsets.
 * 
 * 
 * 
 * 
 */
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        int sum = nums.Sum(x => x);

        if (sum % 2 == 1)
            return false;
        sum /= 2;

        bool[] dp = new bool[sum+1];
        dp[0] = true;
        for(int i = 1; i < nums.Length; i++)
        {
            for (int j = sum; j >= nums[i - 1]; j--) 
            {
				dp[j] = dp[j] || dp[j - nums[i - 1]];
			}
        }
        return dp[sum];
    }
}

