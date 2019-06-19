/*
 * @lc app=leetcode id=39 lang=csharp
 *
 * [39] Combination Sum
 *
 * https://leetcode.com/problems/combination-sum/description/
 *
 * algorithms
 * Medium (47.10%)
 * Likes:    2057
 * Dislikes: 59
 * Total Accepted:    350.4K
 * Total Submissions: 717.1K
 * Testcase Example:  '[2,3,6,7]\n7'
 *
 * Given a set of candidate numbers (candidates) (without duplicates) and a
 * target number (target), find all unique combinations in candidates where the
 * candidate numbers sums to target.
 * 
 * The same repeated number may be chosen from candidates unlimited number of
 * times.
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
 * Input: candidates = [2,3,6,7], target = 7,
 * A solution set is:
 * [
 * ⁠ [7],
 * ⁠ [2,2,3]
 * ]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: candidates = [2,3,5], target = 8,
 * A solution set is:
 * [
 * [2,2,2,2],
 * [2,3,3],
 * [3,5]
 * ]
 * 
 * 
 */
public class Solution
{
    public IList<IList<int>> CombinationSum (int[] candidates, int target)
    {
        var res = new List<IList<int>>();

        Dfs(candidates, target, 0, res, new List<int>(), 0);

        return res;
    }

    public void Dfs(int[] candidates, int target, int sum, IList<IList<int>> res, IList<int> tmp, int index)
    {
        if(index >= candidates.Length)
            return;
        if(sum == target)
        {
            res.Add(new List<int>(tmp));
            return;
        }
        for(int i = index; i < candidates.Length; i++)
        {
            if(sum + candidates[i] <= target)
            {
                tmp.Add(candidates[i]);
                Dfs(candidates, target, sum + candidates[i], res, tmp, i);
                tmp.RemoveAt(tmp.Count() - 1);
            }
        }
    }
}