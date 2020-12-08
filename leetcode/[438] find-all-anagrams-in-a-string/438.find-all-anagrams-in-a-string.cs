/*
 * @lc app=leetcode id=438 lang=csharp
 *
 * [438] Find All Anagrams in a String
 *
 * https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
 *
 * algorithms
 * Easy (36.70%)
 * Likes:    1649
 * Dislikes: 129
 * Total Accepted:    130.1K
 * Total Submissions: 346.3K
 * Testcase Example:  '"cbaebabacd"\n"abc"'
 *
 * Given a string s and a non-empty string p, find all the start indices of p's
 * anagrams in s.
 * 
 * Strings consists of lowercase English letters only and the length of both
 * strings s and p will not be larger than 20,100.
 * 
 * The order of output does not matter.
 * 
 * Example 1:
 * 
 * Input:
 * s: "cbaebabacd" p: "abc"
 * 
 * Output:
 * [0, 6]
 * 
 * Explanation:
 * The substring with start index = 0 is "cba", which is an anagram of "abc".
 * The substring with start index = 6 is "bac", which is an anagram of
 * "abc".
 * 
 * 
 * 
 * Example 2:
 * 
 * Input:
 * s: "abab" p: "ab"
 * 
 * Output:
 * [0, 1, 2]
 * 
 * Explanation:
 * The substring with start index = 0 is "ab", which is an anagram of "ab".
 * The substring with start index = 1 is "ba", which is an anagram of "ab".
 * The substring with start index = 2 is "ab", which is an anagram of "ab".
 * 
 * 
 */
public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        if(s.Length < p.Length) return new List<int>();
        IList<int> res = new List<int>();
        int[] pMap = new int[26];
        foreach(var c in p)
            pMap[c-'a']++;

        int[] sMap = new int[26];
        for(int i = 0; i < p.Length; i++)
            sMap[s[i] - 'a']++;

        if(sMap.SequenceEqual(pMap))
            res.Add(0);

        for(int i = 1; i <= s.Length - p.Length; i++)
        {
            sMap[s[i-1]-'a']--;
            sMap[s[i+p.Length-1]-'a']++;
            if(sMap.SequenceEqual(pMap))
                res.Add(i);
        }
        return res;
    }
}

