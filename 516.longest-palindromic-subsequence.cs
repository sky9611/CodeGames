/*
 * @lc app=leetcode id=516 lang=csharp
 *
 * [516] Longest Palindromic Subsequence
 *
 * https://leetcode.com/problems/longest-palindromic-subsequence/description/
 *
 * algorithms
 * Medium (45.68%)
 * Likes:    915
 * Dislikes: 132
 * Total Accepted:    63.3K
 * Total Submissions: 134.2K
 * Testcase Example:  '"bbbab"'
 *
 * 
 * Given a string s, find the longest palindromic subsequence's length in s.
 * You may assume that the maximum length of s is 1000.
 * 
 * 
 * Example 1:
 * Input: 
 * 
 * "bbbab"
 * 
 * Output: 
 * 
 * 4
 * 
 * One possible longest palindromic subsequence is "bbbb".
 * 
 * 
 * Example 2:
 * Input:
 * 
 * "cbbd"
 * 
 * Output:
 * 
 * 2
 * 
 * One possible longest palindromic subsequence is "bb".
 * 
 */
public class Solution
{
    public int LongestPalindromeSubseq(string s)
    {
        int n = s.Length, cur = 0;
        int[,] dp = new int[2, n];
        for (int i = n - 1; i >= 0; i--)
        {
            dp[cur, i] = 1;
            for(int j = i+1; j < n; j++)
            {
                if(s[i] == s[j])
                    dp[cur, j] = dp[1-cur, j-1] + 2;
                else
                    dp[cur, j] = Math.Max(dp[1-cur, j], dp[cur, j-1]);
            }
            cur = 1- cur;
        }

        return dp[1-cur, n-1];
    }
}

