/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 *
 * https://leetcode.com/problems/merge-intervals/description/
 *
 * algorithms
 * Medium (35.03%)
 * Likes:    2133
 * Dislikes: 165
 * Total Accepted:    357.8K
 * Total Submissions: 999.5K
 * Testcase Example:  '[[1,3],[2,6],[8,10],[15,18]]'
 *
 * Given a collection of intervals, merge all overlapping intervals.
 * 
 * Example 1:
 * 
 * 
 * Input: [[1,3],[2,6],[8,10],[15,18]]
 * Output: [[1,6],[8,10],[15,18]]
 * Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into
 * [1,6].
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [[1,4],[4,5]]
 * Output: [[1,5]]
 * Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 * 
 * NOTE: input types have been changed on April 15, 2019. Please reset to
 * default code definition to get new method signature.
 * 
 */
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Count() == 0)
            return new int[0][];

        intervals = intervals.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

        var res = new List<int[]>();

        res.Add(intervals[0]);
        for (int i = 1; i < intervals.Count(); i++)
        {
            var elem = intervals[i];
            var last = res[res.Count()-1];
            if(elem[0] <= last[1])
                last[1] = Math.Max(elem[1], last[1]);
            else
                res.Add(elem);
        }   

        return res.ToArray();
    }
}

