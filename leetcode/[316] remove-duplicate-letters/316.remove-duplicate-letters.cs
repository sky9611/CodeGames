/*
 * @lc app=leetcode id=316 lang=csharp
 *
 * [316] Remove Duplicate Letters
 */
public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";
        int[] lastIndex = new int[26];
        for (int i = 0; i < s.Length; i++)
            lastIndex[s[i] - 'a'] = i;
        Stack<char> res = new Stack<char>();
        int n = 0;
        while (n < s.Length)
        {
            if (res.Count() > 0)
            {
                if(res.Contains(s[n]))
                {
                    n++;
                    continue;
                }
                char tmp = res.Peek();
                if (tmp < s[n])
                    res.Push(s[n++]);
                else if ((n-1) < lastIndex[tmp - 'a'])
                    res.Pop();
                else    
                    res.Push(s[n++]);
            }
            else
                res.Push(s[n++]);
        }

        List<char> list = res.ToList();
        list.Reverse();
        return new string(list.ToArray());
    }
}

