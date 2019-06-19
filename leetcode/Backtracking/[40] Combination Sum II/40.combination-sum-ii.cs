/*
 * @lc app=leetcode id=40 lang=csharp
 *
 * [40] Combination Sum II
 *
 * https://leetcode.com/problems/combination-sum-ii/description/
 *
 * algorithms
 * Medium (40.47%)
 * Likes:    854
 * Dislikes: 45
 * Total Accepted:    225.4K
 * Total Submissions: 537.7K
 * Testcase Example:  '[10,1,2,7,6,1,5]\n8'
 *
 * Given a collection of candidate numbers (candidates) and a target number
 * (target), find all unique combinations in candidates where the candidate
 * numbers sums to target.
 * 
 * Each number in candidates may only be used once in the combination.
 * 
 * Note:
 * 
 * 
 * All numbers (including target) will be positive integers.
 * The solution set must not contain duplicate combinations.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: candidates = [10,1,2,7,6,1,5], target = 8,
 * A solution set is:
 * [
 * ⁠ [1, 7],
 * ⁠ [1, 2, 5],
 * ⁠ [2, 6],
 * ⁠ [1, 1, 6]
 * ]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: candidates = [2,5,2,1,2], target = 5,
 * A solution set is:
 * [
 * [1,2,2],
 * [5]
 * ]
 * 
 * 
 */
public class Solution
{
    public IList<IList<int>> CombinationSum2 (int[] candidates, int target)
    {
        var res = new List<IList<int>> ();
        
        Dfs (candidates.OrderBy(x => x).ToArray(), target, 0, res, new List<int> (), 0);

        return res;
    }

    public void Dfs (int[] candidates, int target, int sum, IList<IList<int>> res, IList<int> tmp, int index)
    {
        if (index >= candidates.Count())
            return;
        if (sum == target)
        {
            res.Add (new List<int> (tmp));
            return;
        }
        int start = tmp.Count() == 0 ? index : index + 1;
        int pre = start<candidates.Count() ? candidates[start]-1 : 0;
        for (int i = start; i < candidates.Count(); i++)
        {
            if (candidates[i] == pre)
                continue;
            if (sum + candidates[i] <= target)
            {
                tmp.Add (candidates[i]);
                Dfs (candidates, target, sum + candidates[i], res, tmp, i);
                tmp.RemoveAt (tmp.Count () - 1);
            }
            pre = candidates[i];
        }
    }
}