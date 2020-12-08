/*
 * @lc app=leetcode id=76 lang=csharp
 *
 * [76] Minimum Window Substring
 *
 * https://leetcode.com/problems/minimum-window-substring/description/
 *
 * algorithms
 * Hard (30.05%)
 * Likes:    2367
 * Dislikes: 161
 * Total Accepted:    244.9K
 * Total Submissions: 788.2K
 * Testcase Example:  '"ADOBECODEBANC"\n"ABC"'
 *
 * Given a string S and a string T, find the minimum window in S which will
 * contain all the characters in T in complexity O(n).
 * 
 * Example:
 * 
 * 
 * Input: S = "ADOBECODEBANC", T = "ABC"
 * Output: "BANC"
 * 
 * 
 * Note:
 * 
 * 
 * If there is no such window in S that covers all characters in T, return the
 * empty string "".
 * If there is such window, you are guaranteed that there will always be only
 * one unique minimum window in S.
 * 
 * 
 */
public class Solution
{
    public string MinWindow(string s, string t)
    {
        // Dictionary<char, int> tMap = new Dictionary<char, int>();
        // Dictionary<char, int> sMap = new Dictionary<char, int>();

        int[] tMap = new int[128];

        for (int k = 0; k < t.Length; k++)
            tMap[t[k]]++;

        int cnt = t.Length;
        int start = 0;
        int ans_s = 0, ans_e = s.Length + 1;
        for (int k = 0; k < s.Length; k++)
        {
            if (tMap[s[k]]-- > 0) cnt--;

            while (cnt == 0)
            {
                if (k - start < ans_e - ans_s)
                {
                    ans_s = start;
                    ans_e = k;
                }

                if (++tMap[s[start]] > 0)
                    ++cnt;

                ++start;
            }
        }

        int len = ans_e - ans_s + 1;

        return len <= s.Length ? s.Substring(ans_s, len) : "";
    }
}

