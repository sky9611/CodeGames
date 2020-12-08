/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 *
 * https://leetcode.com/problems/insert-interval/description/
 *
 * algorithms
 * Hard (30.86%)
 * Likes:    847
 * Dislikes: 107
 * Total Accepted:    179.8K
 * Total Submissions: 574.2K
 * Testcase Example:  '[[1,3],[6,9]]\n[2,5]'
 *
 * Given a set of non-overlapping intervals, insert a new interval into the
 * intervals (merge if necessary).
 * 
 * You may assume that the intervals were initially sorted according to their
 * start times.
 * 
 * Example 1:
 * 
 * 
 * Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
 * Output: [[1,5],[6,9]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
 * Output: [[1,2],[3,10],[12,16]]
 * Explanation: Because the new interval [4,8] overlaps with
 * [3,5],[6,7],[8,10].
 * 
 * NOTE: input types have been changed on April 15, 2019. Please reset to
 * default code definition to get new method signature.
 * 
 */
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Count() == 0)
            return new int[][]{newInterval};

        List<int[]> intervalsList = new List<int[]>(intervals);
        intervalsList.Add(newInterval);
        intervalsList = intervalsList.OrderBy(x => x[0]).ToList();

        var res = new List<int[]>();

        res.Add(intervalsList[0]);
        for (int i = 1; i < intervalsList.Count(); i++)
        {
            var elem = intervalsList[i];
            var last = res[res.Count()-1];
            if(elem[0] <= last[1])
                last[1] = Math.Max(elem[1], last[1]);
            else
                res.Add(elem);
        }   

        return res.ToArray();
    }
}

