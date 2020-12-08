/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 *
 * https://leetcode.com/problems/trapping-rain-water/description/
 *
 * algorithms
 * Hard (42.22%)
 * Likes:    3687
 * Dislikes: 67
 * Total Accepted:    300.5K
 * Total Submissions: 691.9K
 * Testcase Example:  '[0,1,0,2,1,0,1,3,2,1,2,1]'
 *
 * Given n non-negative integers representing an elevation map where the width
 * of each bar is 1, compute how much water it is able to trap after raining.
 * 
 * 
 * The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
 * In this case, 6 units of rain water (blue section) are being trapped. Thanks
 * Marcos for contributing this image!
 * 
 * Example:
 * 
 * 
 * Input: [0,1,0,2,1,0,1,3,2,1,2,1]
 * Output: 6
 * 
 */
public class Solution
{
    public int Trap (int[] height)
    {
        int length = height.Count();
        // int res = 0;
        // int maxLeftHeight = 0;
        // int maxRightHeight = 0;
        // int B = 0;

        // for(int i = 0; i < length; i++)
        // {
        //     maxLeftHeight = Math.Max(maxLeftHeight, height[i]);
        //     maxRightHeight = Math.Max(maxRightHeight, height[length-i-1]);
        //     res += maxLeftHeight + maxRightHeight;
        //     B += height[i] + height[length-i-1];
        // }

        // return (int)(res - B/2 - Math.Max(maxLeftHeight, maxRightHeight) * length); 
        
        int left = 0;
        int right = length - 1;
        int min = 0;
        int res = 0;
        while(left < right)
        {
            int val = Math.Min(height[left], height[right]);
            if(val < min)
                res += min - val;
            else
                min = val;

            if(height[left] <= height[right])
                left++;
            else
                right--;
        }
        return res;
    }
}