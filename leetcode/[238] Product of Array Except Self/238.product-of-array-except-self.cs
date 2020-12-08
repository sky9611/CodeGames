/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 *
 * https://leetcode.com/problems/product-of-array-except-self/description/
 *
 * algorithms
 * Medium (54.12%)
 * Likes:    2325
 * Dislikes: 196
 * Total Accepted:    267.1K
 * Total Submissions: 482.2K
 * Testcase Example:  '[1,2,3,4]'
 *
 * Given an array nums of n integers where n > 1,  return an array output such
 * that output[i] is equal to the product of all the elements of nums except
 * nums[i].
 * 
 * Example:
 * 
 * 
 * Input:  [1,2,3,4]
 * Output: [24,12,8,6]
 * 
 * 
 * Note: Please solve it without division and in O(n).
 * 
 * Follow up:
 * Could you solve it with constant space complexity? (The output array does
 * not count as extra space for the purpose of space complexity analysis.)
 * 
 */
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] ans = new int[nums.Count()];
        int product = 1;
        int zeroCount = 0;
        int zeroPosition = -1;
        for(int i = 0; i< nums.Count(); i++)
        {
            if(nums[i] == 0)
            {
                if(++zeroCount > 1)
                    return ans;
                zeroPosition = i;
                continue;
            }
            
            product *= nums[i];
        }


        if(zeroPosition>-1)
        {
            ans[zeroPosition] = product;
            return ans;
        }

        for (int i = 0; i < nums.Count(); i++)
            ans[i] = product/nums[i];
        
        return ans;
    }
}

