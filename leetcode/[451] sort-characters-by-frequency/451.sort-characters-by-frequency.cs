/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 *
 * https://leetcode.com/problems/sort-characters-by-frequency/description/
 *
 * algorithms
 * Medium (55.24%)
 * Likes:    746
 * Dislikes: 64
 * Total Accepted:    97.8K
 * Total Submissions: 173.3K
 * Testcase Example:  '"tree"'
 *
 * Given a string, sort it in decreasing order based on the frequency of
 * characters.
 * 
 * Example 1:
 * 
 * Input:
 * "tree"
 * 
 * Output:
 * "eert"
 * 
 * Explanation:
 * 'e' appears twice while 'r' and 't' both appear once.
 * So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid
 * answer.
 * 
 * 
 * 
 * Example 2:
 * 
 * Input:
 * "cccaaa"
 * 
 * Output:
 * "cccaaa"
 * 
 * Explanation:
 * Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
 * Note that "cacaca" is incorrect, as the same characters must be together.
 * 
 * 
 * 
 * Example 3:
 * 
 * Input:
 * "Aabb"
 * 
 * Output:
 * "bbAa"
 * 
 * Explanation:
 * "bbaA" is also a valid answer, but "Aabb" is incorrect.
 * Note that 'A' and 'a' are treated as two different characters.
 * 
 * 
 */
public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(var c in s)
        {
            int tmp;
            if(map.TryGetValue(c, out tmp))
                map[c]++;
            else
                map[c] = 1;
        }
        var list = map.OrderByDescending(x => x.Value).ToList();
        StringBuilder res=new StringBuilder();
        foreach(var t in list)
        {
            for(int i = 0; i < t.Value; i++)
                res.Append(t.Key);
        }
        return res.ToString();
        
    }
}

