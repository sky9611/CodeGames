/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 *
 * https://leetcode.com/problems/valid-anagram/description/
 *
 * algorithms
 * Easy (51.21%)
 * Likes:    737
 * Dislikes: 109
 * Total Accepted:    353.6K
 * Total Submissions: 672.8K
 * Testcase Example:  '"anagram"\n"nagaram"'
 *
 * Given two strings s and t , write a function to determine if t is an anagram
 * of s.
 * 
 * Example 1:
 * 
 * 
 * Input: s = "anagram", t = "nagaram"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "rat", t = "car"
 * Output: false
 * 
 * 
 * Note:
 * You may assume the string contains only lowercase alphabets.
 * 
 * Follow up:
 * What if the inputs contain unicode characters? How would you adapt your
 * solution to such case?
 * 
 */
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        int[] map = new int[126];
        foreach(var c in s)
            map[c]++;
        
        foreach(var c in t)
        {
            if(--map[c] < 0)
                return false;
        }
        
        return true;
    }
}

