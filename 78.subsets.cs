/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 *
 * https://leetcode.com/problems/subsets/description/
 *
 * algorithms
 * Medium (51.41%)
 * Likes:    1983
 * Dislikes: 50
 * Total Accepted:    374.5K
 * Total Submissions: 703.4K
 * Testcase Example:  '[1,2,3]'
 *
 * Given a set of distinct integers, nums, return all possible subsets (the
 * power set).
 * 
 * Note: The solution set must not contain duplicate subsets.
 * 
 * Example:
 * 
 * 
 * Input: nums = [1,2,3]
 * Output:
 * [
 * ⁠ [3],
 * [1],
 * [2],
 * [1,2,3],
 * [1,3],
 * [2,3],
 * [1,2],
 * []
 * ]
 * 
 */
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var res = new List<IList<int>>();
        Dfs(nums, res, new List<int>(), 0);
        return res;
    }

    public void Dfs(int[] nums, IList<IList<int>> res, IList<int> tmp, int index)
    {
        res.Add(new List<int>(tmp));

        if (index >= nums.Count())
            return;

        for (int i = index; i < nums.Count(); i++)
        {
            tmp.Add(nums[i]);
            Dfs(nums, res, tmp, i + 1);
            tmp.RemoveAt(tmp.Count() - 1);
        }
    }
}

