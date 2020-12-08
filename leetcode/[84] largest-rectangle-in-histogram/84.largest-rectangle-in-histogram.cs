/*
 * @lc app=leetcode id=84 lang=csharp
 *
 * [84] Largest Rectangle in Histogram
 *
 * https://leetcode.com/problems/largest-rectangle-in-histogram/description/
 *
 * algorithms
 * Hard (30.43%)
 * Likes:    1949
 * Dislikes: 54
 * Total Accepted:    179.3K
 * Total Submissions: 570.5K
 * Testcase Example:  '[2,1,5,6,2,3]'
 *
 * Given n non-negative integers representing the histogram's bar height where
 * the width of each bar is 1, find the area of largest rectangle in the
 * histogram.
 * 
 * 
 * 
 * 
 * Above is a histogram where width of each bar is 1, given height =
 * [2,1,5,6,2,3].
 * 
 * 
 * 
 * 
 * The largest rectangle is shown in the shaded area, which has area = 10
 * unit.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input: [2,1,5,6,2,3]
 * Output: 10
 * 
 * 
 */
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights.Count() == 0)
            return 0;
        List<int> list = new List<int>(heights);
        list.Add(0); 
        Stack<int> stack = new Stack<int>();
        int res = 0;
        for (int i = 0; i < list.Count(); i++)
        {
            int cur = list[i];
            while (stack.Count() > 0 && list[stack.Peek()] > cur)
            {
                int tmp = stack.Pop();
                int la = (stack.Count() == 0 ? tmp + 1 : tmp - stack.Peek()) * list[tmp];
                int ra = (i - tmp - 1) * list[tmp];
                if((la + ra) > res) res = la + ra;
            }
            stack.Push(i);
        }
        return res;
    }
}

