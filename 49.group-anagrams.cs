/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 *
 * https://leetcode.com/problems/group-anagrams/description/
 *
 * algorithms
 * Medium (45.20%)
 * Likes:    1705
 * Dislikes: 115
 * Total Accepted:    347.9K
 * Total Submissions: 735.7K
 * Testcase Example:  '["eat","tea","tan","ate","nat","bat"]'
 *
 * Given an array of strings, group anagrams together.
 * 
 * Example:
 * 
 * 
 * Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
 * Output:
 * [
 * ⁠ ["ate","eat","tea"],
 * ⁠ ["nat","tan"],
 * ⁠ ["bat"]
 * ]
 * 
 * Note:
 * 
 * 
 * All inputs will be in lowercase.
 * The order of your output does not matter.
 * 
 * 
 */
public class Solution
{
    int[] valArray = new int[]{2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,101};
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        IList<IList<string>> res = new List<IList<string>>();
        foreach(var s in strs)
        {
            int index;
            int val = GetValue(s);
            if(map.TryGetValue(val, out index))
            {
                res[index].Add(s);
            }
            else
            {
                res.Add(new List<string>());
                map[val] = res.Count() - 1;
                res[res.Count() - 1].Add(s);
            }

        }

        return res;
    }

    public int GetValue(string str)
    {
        int res = 1;
        foreach(var c in str)
            res *= valArray[c-'a'];
        return res;
    }
}

