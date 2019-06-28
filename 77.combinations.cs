/*
 * @lc app=leetcode id=77 lang=csharp
 *
 * [77] Combinations
 *
 * https://leetcode.com/problems/combinations/description/
 *
 * algorithms
 * Medium (46.34%)
 * Likes:    793
 * Dislikes: 47
 * Total Accepted:    207.8K
 * Total Submissions: 431.5K
 * Testcase Example:  '4\n2'
 *
 * Given two integers n and k, return all possible combinations of k numbers
 * out of 1 ... n.
 * 
 * Example:
 * 
 * 
 * Input: n = 4, k = 2
 * Output:
 * [
 * ⁠ [2,4],
 * ⁠ [3,4],
 * ⁠ [2,3],
 * ⁠ [1,2],
 * ⁠ [1,3],
 * ⁠ [1,4],
 * ]
 * 
 * 
 */
public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        List<IList<int>> ans = new List<IList<int>>();
        Foo(n, k, ans, new List<int>(), 1);
        return ans;
    }

    public void Foo(int n, int k, IList<IList<int>> ans, List<int> tmp, int c)
    {
        if(tmp.Count() == k)
        {
            ans.Add(new List<int>(tmp));
            return;
        }

        for(int i = c; i <= n; i++)
        {
            tmp.Add(i);
            Foo(n, k, ans, tmp, i+1);
            tmp.RemoveAt(tmp.Count() - 1);
        }
    }
}

