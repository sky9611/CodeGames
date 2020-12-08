/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 *
 * https://leetcode.com/problems/generate-parentheses/description/
 *
 * algorithms
 * Medium (53.54%)
 * Likes:    2858
 * Dislikes: 178
 * Total Accepted:    351.1K
 * Total Submissions: 633.5K
 * Testcase Example:  '3'
 *
 * 
 * Given n pairs of parentheses, write a function to generate all combinations
 * of well-formed parentheses.
 * 
 * 
 * 
 * For example, given n = 3, a solution set is:
 * 
 * 
 * [
 * ⁠ "((()))",
 * ⁠ "(()())",
 * ⁠ "(())()",
 * ⁠ "()(())",
 * ⁠ "()()()"
 * ]
 * 
 */
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();
        var tmp = new StringBuilder();

        Dfs(res, "", n, n);

        return res;
    }

    public void Dfs(IList<string> res, string tmp, int left, int right)
    {
        if (left == 0 && right == 0)
        {
            res.Add(tmp.ToString());
            return;
        }

        if (left > 0)
            Dfs(res, tmp + "(", left - 1, right);

        if (left < right)
            Dfs(res, tmp + ")", left, right - 1);
    }
}

