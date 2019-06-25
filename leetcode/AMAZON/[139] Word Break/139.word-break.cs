/*
 * @lc app=leetcode id=139 lang=csharp
 *
 * [139] Word Break
 *
 * https://leetcode.com/problems/word-break/description/
 *
 * algorithms
 * Medium (34.56%)
 * Likes:    2269
 * Dislikes: 123
 * Total Accepted:    345.9K
 * Total Submissions: 971.9K
 * Testcase Example:  '"leetcode"\n["leet","code"]'
 *
 * Given a non-empty string s and a dictionary wordDict containing a list of
 * non-empty words, determine if s can be segmented into a space-separated
 * sequence of one or more dictionary words.
 * 
 * Note:
 * 
 * 
 * The same word in the dictionary may be reused multiple times in the
 * segmentation.
 * You may assume the dictionary does not contain duplicate words.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "leetcode", wordDict = ["leet", "code"]
 * Output: true
 * Explanation: Return true because "leetcode" can be segmented as "leet
 * code".
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "applepenapple", wordDict = ["apple", "pen"]
 * Output: true
 * Explanation: Return true because "applepenapple" can be segmented as "apple
 * pen apple".
 * Note that you are allowed to reuse a dictionary word.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
 * Output: false
 * 
 * 
 */
public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        // DP
        // int len = s.Length;
        // bool[] dp = new bool[len + 1];
        // dp[0] = true;
        // for(int i = 1; i < dp.Count(); i++)
        // {
        //     for(int j = 0; j < i; j++)
        //     {
        //         var tmp = s.Substring(j, i-j);
        //         if(dp[j] && wordDict.Contains(tmp))
        //         {
        //             dp[i] = true;
        //             break;
        //         }
        //     }
        // }

        // return dp[len];
        return dfs(s, wordDict, 0, new bool[s.Length]);
    }

    public bool dfs(string s, IList<string> wordDict, int start, bool[] visited)
    {
        if (start == s.Length) return true;
        if (visited[start]) return false;

        visited[start] = true;
        foreach (var word in wordDict)
        {
            int newStart = start + word.Length;
            if (newStart > s.Length)
                continue;
            if (word == s.Substring(start, word.Length) && dfs(s, wordDict, newStart, visited))
                return true;
        }
        return false;
    }
}

