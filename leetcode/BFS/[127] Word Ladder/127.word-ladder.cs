/*
 * @lc app=leetcode id=127 lang=csharp
 *
 * [127] Word Ladder
 *
 * https://leetcode.com/problems/word-ladder/description/
 *
 * algorithms
 * Medium (23.20%)
 * Total Accepted:    237.4K
 * Total Submissions: 1M
 * Testcase Example:  '"hit"\n"cog"\n["hot","dot","dog","lot","log","cog"]'
 *
 * Given two words (beginWord and endWord), and a dictionary's word list, find
 * the length of shortest transformation sequence from beginWord to endWord,
 * such that:
 * 
 * 
 * Only one letter can be changed at a time.
 * Each transformed word must exist in the word list. Note that beginWord is
 * not a transformed word.
 * 
 * 
 * Note:
 * 
 * 
 * Return 0 if there is no such transformation sequence.
 * All words have the same length.
 * All words contain only lowercase alphabetic characters.
 * You may assume no duplicates in the word list.
 * You may assume beginWord and endWord are non-empty and are not the same.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input:
 * beginWord = "hit",
 * endWord = "cog",
 * wordList = ["hot","dot","dog","lot","log","cog"]
 * 
 * Output: 5
 * 
 * Explanation: As one shortest transformation is "hit" -> "hot" -> "dot" ->
 * "dog" -> "cog",
 * return its length 5.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input:
 * beginWord = "hit"
 * endWord = "cog"
 * wordList = ["hot","dot","dog","lot","log"]
 * 
 * Output: 0
 * 
 * Explanation: The endWord "cog" is not in wordList, therefore no possible
 * transformation.
 * 
 * 
 * 
 * 
 * 
 */
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        if (!wordList.Contains(endWord)) return 0;
        int[,] am = new int[wordList.Count+1,wordList.Count+1];
        List<string> list = wordList as List<string>;
        list.Add(beginWord);
        list.Reverse();
        for (int i=0;i<list.Count;i++)
        {
            for (int j=0;j<list.Count;j++)
            {
                if(isNeighbour(list[i],list[j]))
                    am[i,j] = 1;
            }
        }

        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        for (int i=1;i<list.Count;i++)
        {
            if (am[0,i]==1)
                queue.Enqueue(new Tuple<int, int>(i, 1));
        }
        while(queue.Count>0)
        {
            Tuple<int,int> tuple = queue.Dequeue();
            int index = tuple.Item1;
            int distance = tuple.Item2;
            if (list[index]==endWord)
                return distance;
            else
            {
                for (int i=1;i<list.Count;i++)
                {
                    if (am[index,i]==1)
                        queue.Enqueue(new Tuple<int, int>(i, distance+1));
                }
            }
        }
        return 0; 
    }

    private bool isNeighbour(string s1, string s2)
    {
        int dist = 0;
        for(int i=0;i<s1.Length;i++)
        {
            dist = s1[i]==s2[i] ? dist : dist+1;
            if(dist>1)
                return false;                
        }
        if(dist==1)
            return true;
        else 
            return false;
    }
}

