/*
 * @lc app=leetcode id=452 lang=csharp
 *
 * [452] Minimum Number of Arrows to Burst Balloons
 */
public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points == null || points.Length == 0)
            return 0;

        List<int[]> list =  points.ToList().OrderBy(x => x[1]).ToList();
        int cur = list[0][1];
        int res = 1;
        foreach(var point in list)
        {
            if( point[0] > cur)
            {
                cur = point[1];
                res ++;
            }
        }
        return res;
    }
}

