/*
 * @lc app=leetcode id=692 lang=csharp
 *
 * [692] Top K Frequent Words
 *
 * https://leetcode.com/problems/top-k-frequent-words/description/
 *
 * algorithms
 * Medium (45.00%)
 * Likes:    769
 * Dislikes: 71
 * Total Accepted:    68K
 * Total Submissions: 147.7K
 * Testcase Example:  '["i", "love", "leetcode", "i", "love", "coding"]\n2'
 *
 * Given a non-empty list of words, return the k most frequent elements.
 * Your answer should be sorted by frequency from highest to lowest. If two
 * words have the same frequency, then the word with the lower alphabetical
 * order comes first.
 * 
 * Example 1:
 * 
 * Input: ["i", "love", "leetcode", "i", "love", "coding"], k = 2
 * Output: ["i", "love"]
 * Explanation: "i" and "love" are the two most frequent words.
 * ⁠   Note that "i" comes before "love" due to a lower alphabetical order.
 * 
 * 
 * 
 * Example 2:
 * 
 * Input: ["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is",
 * "is"], k = 4
 * Output: ["the", "is", "sunny", "day"]
 * Explanation: "the", "is", "sunny" and "day" are the four most frequent
 * words,
 * ⁠   with the number of occurrence being 4, 3, 2 and 1 respectively.
 * 
 * 
 * 
 * Note:
 * 
 * You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
 * Input words contain only lowercase letters.
 * 
 * 
 * 
 * Follow up:
 * 
 * Try to solve it in O(n log k) time and O(n) extra space.
 * 
 * 
 */
public class Solution
{
    Dictionary<string, int> map = new Dictionary<string, int>();
    public IList<string> TopKFrequent(string[] words, int k)
    {
        SortedSet<string> sl = new SortedSet<string>(new MyComparer(map));        
        
        foreach(var word in words)
        {
            if(map.ContainsKey(word))
                map[word]++;
            else
                map[word] = 0;
        }

        foreach(var word in words)
        {
            sl.Add(word);
        }

        List<string> res = new List<string>();
        var list = sl.ToList();
        for(int i = 0; i < k; i++)
            res.Add(list[i]);

        // Console.Write(map["bisvwmpqh"] + " " + map["kjf"] + " " + map["drrzney"]);

        return res;
    }

    public class MyComparer : IComparer<string>
    {
        Dictionary<string, int> mmap;

        public MyComparer(Dictionary<string, int> map)
        {
            mmap = map;
        }
        public int Compare(string x, string y)
        {
            if(x==y) return 0;
            if(mmap[x] > mmap[y]) 
                return -1;
            if(mmap[x] < mmap[y])
                return 1;
            
            for(int i = 0; i < x.Length; i++)
            {
                if(i == y.Length) return 1;
                if(x[i] > y[i]) return 1;
                if(x[i] < y[i]) return -1;
            }
            
            return -1;
        }
    }
}


