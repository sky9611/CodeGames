/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 *
 * https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
 *
 * algorithms
 * Easy (52.86%)
 * Likes:    1713
 * Dislikes: 163
 * Total Accepted:    161.7K
 * Total Submissions: 301.1K
 * Testcase Example:  '[4,3,2,7,8,2,3,1]'
 *
 * Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some
 * elements appear twice and others appear once.
 * 
 * Find all the elements of [1, n] inclusive that do not appear in this array.
 * 
 * Could you do it without extra space and in O(n) runtime? You may assume the
 * returned list does not count as extra space.
 * 
 * Example:
 * 
 * Input:
 * [4,3,2,7,8,2,3,1]
 * 
 * Output:
 * [5,6]
 * 
 * 
 */
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();
        int len = nums.Length;
        for (int i = 0; i < len; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
                nums[index] = -nums[index];
        }
        for (int i = 0; i < len; i++) {
            if (nums[i] > 0)
                result.Add(i + 1);
        }
        return result;
    }
}

