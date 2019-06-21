/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 *
 * https://leetcode.com/problems/sort-colors/description/
 *
 * algorithms
 * Medium (41.50%)
 * Likes:    1668
 * Dislikes: 159
 * Total Accepted:    324.8K
 * Total Submissions: 766.4K
 * Testcase Example:  '[2,0,2,1,1,0]'
 *
 * Given an array with n objects colored red, white or blue, sort them in-place
 * so that objects of the same color are adjacent, with the colors in the order
 * red, white and blue.
 * 
 * Here, we will use the integers 0, 1, and 2 to represent the color red,
 * white, and blue respectively.
 * 
 * Note: You are not suppose to use the library's sort function for this
 * problem.
 * 
 * Example:
 * 
 * 
 * Input: [2,0,2,1,1,0]
 * Output: [0,0,1,1,2,2]
 * 
 * Follow up:
 * 
 * 
 * A rather straight forward solution is a two-pass algorithm using counting
 * sort.
 * First, iterate the array counting number of 0's, 1's, and 2's, then
 * overwrite array with total number of 0's, then 1's and followed by 2's.
 * Could you come up with a one-pass algorithm using only constant space?
 * 
 * 
 */
public class Solution
{
    public void SortColors(int[] nums)
    {
        int length = nums.Count();
        int start = 0;
        int end = length - 1;
        int cur = 0;
        while(cur <= end && start < length && end >= 0)
        {
            if(nums[cur] == 0)
            {
                int tmp = nums[cur];
                nums[cur++] = nums[start];
                nums[start++] = tmp;
            } else if(nums[cur] == 1)
            {
                int tmp = nums[cur];
                nums[cur++] = nums[start];
                nums[start] = tmp;
            } else if(nums[cur] == 2)
            {
                int tmp = nums[cur];
                nums[cur] = nums[end];
                nums[end--] = tmp;
            }
        }
    }
}

