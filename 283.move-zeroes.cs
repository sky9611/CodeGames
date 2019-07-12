/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 *
 * https://leetcode.com/problems/move-zeroes/description/
 *
 * algorithms
 * Easy (53.78%)
 * Likes:    2122
 * Dislikes: 79
 * Total Accepted:    485.2K
 * Total Submissions: 888.4K
 * Testcase Example:  '[0,1,0,3,12]'
 *
 * Given an array nums, write a function to move all 0's to the end of it while
 * maintaining the relative order of the non-zero elements.
 * 
 * Example:
 * 
 * 
 * Input: [0,1,0,3,12]
 * Output: [1,3,12,0,0]
 * 
 * Note:
 * 
 * 
 * You must do this in-place without making a copy of the array.
 * Minimize the total number of operations.
 * 
 */
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        if(nums.Count() == 0 || nums.Count() == 1) return;
        int i = 0, j = 0;
        while(true)
        {
            while(j < nums.Length && nums[j] != 0)
                j++;

            while(i < nums.Length && nums[i] == 0)
                i++;

            if(i == nums.Length || j == nums.Length) break;

            if(i > j)
            {
                nums[j] = nums[i];
                nums[i] = 0;
            }
            else
            {
                i++;
            }
        }
    }
}

