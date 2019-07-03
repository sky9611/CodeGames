/*
 * @lc app=leetcode id=97 lang=csharp
 *
 * [97] Interleaving String
 *
 * https://leetcode.com/problems/interleaving-string/description/
 *
 * algorithms
 * Hard (27.45%)
 * Likes:    800
 * Dislikes: 38
 * Total Accepted:    113.8K
 * Total Submissions: 403.5K
 * Testcase Example:  '"aabcc"\n"dbbca"\n"aadbbcbcac"'
 *
 * Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and
 * s2.
 * 
 * Example 1:
 * 
 * 
 * Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc"
 * Output: false
 * 
 * 
 */
public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int a = s1.Length, b = s2.Length, c = s3.Length;
        if (a + b != c)
            return false;
        bool[,] dp = new bool[a + 1, b + 1];
        dp[0, 0] = true;
        for (int i = 0; i < a + 1; i++)
        {
            for (int j = 0; j < b + 1; j++)
            {
                if (dp[i, j]
                || ((i - 1) >= 0 && dp[i - 1, j] && s1[i - 1] == s3[i + j - 1])
                || ((j - 1) >= 0 && dp[i, j - 1] && s2[j - 1] == s3[i + j - 1]))
                {
                    dp[i, j] = true;
                }
            }
        }
        return dp[a, b];
    }
}

