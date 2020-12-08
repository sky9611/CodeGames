/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 *
 * https://leetcode.com/problems/3sum-closest/description/
 *
 * algorithms
 * Medium (41.64%)
 * Likes:    1119
 * Dislikes: 82
 * Total Accepted:    350.8K
 * Total Submissions: 766.4K
 * Testcase Example:  '[-1,2,1,-4]\n1'
 *
 * Given an array nums of n integers and an integer target, find three integers
 * in nums such that the sum is closest to target. Return the sum of the three
 * integers. You may assume that each input would have exactly one solution.
 * 
 * Example:
 * 
 * 
 * Given array nums = [-1, 2, 1, -4], and target = 1.
 * 
 * The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
 * 
 * 
 */
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    { 
        nums = nums.OrderBy(x => x).ToArray();
        int res = nums[0] + nums[1] + nums[nums.Count()-1];
        for(int i = 0; i < nums.Count() - 2; i++)
        {
            int j = i + 1;
            int k = nums.Count() - 1;
            int tmp;
            while(j<k)
            {
                tmp = nums[i] + nums[j] + nums[k];
                res = Math.Abs(res - target) > Math.Abs(tmp - target) ? tmp : res; 
                if (Math.Abs(res - target) == 0)
                    return res;
                int tmpIndex;
                if(tmp < target)
                    ++j;
                else
                    --k;
            }
            // while()
        }
        return res;
    }
}

