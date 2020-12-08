/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 *
 * https://leetcode.com/problems/container-with-most-water/description/
 *
 * algorithms
 * Medium (43.05%)
 * Likes:    3325
 * Dislikes: 441
 * Total Accepted:    379.3K
 * Total Submissions: 846.9K
 * Testcase Example:  '[1,8,6,2,5,4,8,3,7]'
 *
 * Given n non-negative integers a1, a2, ..., an , where each represents a
 * point at coordinate (i, ai). n vertical lines are drawn such that the two
 * endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together
 * with x-axis forms a container, such that the container contains the most
 * water.
 * 
 * Note: You may not slant the container and n is at least 2.
 * 
 * 
 * 
 * 
 * 
 * The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In
 * this case, the max area of water (blue section) the container can contain is
 * 49. 
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input: [1,8,6,2,5,4,8,3,7]
 * Output: 49
 * 
 */
public class Solution
{
    public int MaxArea(int[] height)
    {
        int i = 0;
        int j = height.Count()-1;
        int res = 0;
        while( i < j)
        {
            int area = Area(height, i, j);
            res = Math.Max(area, res);
            int tmp = 0;
            if(height[i] < height[j])
            {
                tmp = i;
                while(height[i] <= height[tmp] && i < j)
                    i++;
            } 
            else
            {
                tmp = j;
                while(height[j] <= height[tmp] && i < j)
                    j--;
            }
        }
        return res;
    }

    public int Area(int[] height, int i, int j)
    {
        if (j < i)
            return Area(height, j, i);
        return Math.Min(height[i], height[j]) * ( j - i);
    }
}

