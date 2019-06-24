/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 *
 * https://leetcode.com/problems/first-unique-character-in-a-string/description/
 *
 * algorithms
 * Easy (49.39%)
 * Likes:    1028
 * Dislikes: 79
 * Total Accepted:    277.7K
 * Total Submissions: 553.1K
 * Testcase Example:  '"leetcode"'
 *
 * 
 * Given a string, find the first non-repeating character in it and return it's
 * index. If it doesn't exist, return -1.
 * 
 * Examples:
 * 
 * s = "leetcode"
 * return 0.
 * 
 * s = "loveleetcode",
 * return 2.
 * 
 * 
 * 
 * 
 * Note: You may assume the string contain only lowercase letters.
 * 
 */
public class Solution
{
    public int FirstUniqChar(string s)
    {
        int[] map = new int[26];
        for (int i = 0; i < s.Length; i++)
            map[s[i]-'a']++;
        for (int i = 0; i < s.Length; i++)
            if(map[s[i]-'a'] == 1)
                return i;

        // for (int i = 0; i < s.Length; i++)
        //     if(s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
        //         return i;

        
        return -1;
    }
}

