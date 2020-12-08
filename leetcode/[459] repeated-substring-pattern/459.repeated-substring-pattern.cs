/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 *
 * https://leetcode.com/problems/repeated-substring-pattern/description/
 *
 * algorithms
 * Easy (39.51%)
 * Likes:    817
 * Dislikes: 100
 * Total Accepted:    82.3K
 * Total Submissions: 205.7K
 * Testcase Example:  '"abab"'
 *
 * Given a non-empty string check if it can be constructed by taking a
 * substring of it and appending multiple copies of the substring together. You
 * may assume the given string consists of lowercase English letters only and
 * its length will not exceed 10000.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: "abab"
 * Output: True
 * Explanation: It's the substring "ab" twice.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "aba"
 * Output: False
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "abcabcabcabc"
 * Output: True
 * Explanation: It's the substring "abc" four times. (And the substring
 * "abcabc" twice.)
 * 
 * 
 */
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        if(s.Length == 0 || s.Length == 1) return false;
        int i = 1;
        while(i*i <= s.Length)
        {
            int count = 0;
            if (s.Length % i == 0)
            {
                count = s.Length / i;
                string atom = s.Substring(0, i);
                int j;
                for(j = 1; j < count; j++)
                    if(s.Substring(j * i, i) != atom)
                        break;
                if(j == count)
                    return true;
                
                if(count < s.Length)
                {
                    atom = s.Substring(0, count);
                    for(j = 1; j < i; j++)
                        if(s.Substring(j * count, count) != atom)
                            break;
                    if(j == i)
                        return true;

                }
            }
            i++;
        }

        return false;
    }
}

