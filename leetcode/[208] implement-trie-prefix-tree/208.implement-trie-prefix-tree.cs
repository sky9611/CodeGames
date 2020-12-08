/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 *
 * https://leetcode.com/problems/implement-trie-prefix-tree/description/
 *
 * algorithms
 * Medium (37.10%)
 * Likes:    1660
 * Dislikes: 34
 * Total Accepted:    186.3K
 * Total Submissions: 475.4K
 * Testcase Example:  '["Trie","insert","search","search","startsWith","insert","search"]\n[[],["apple"],["apple"],["app"],["app"],["app"],["app"]]'
 *
 * Implement a trie with insert, search, and startsWith methods.
 * 
 * Example:
 * 
 * 
 * Trie trie = new Trie();
 * 
 * trie.insert("apple");
 * trie.search("apple");   // returns true
 * trie.search("app");     // returns false
 * trie.startsWith("app"); // returns true
 * trie.insert("app");   
 * trie.search("app");     // returns true
 * 
 * 
 * Note:
 * 
 * 
 * You may assume that all inputs are consist of lowercase letters a-z.
 * All inputs are guaranteed to be non-empty strings.
 * 
 * 
 */
public class Trie
{
    public Dictionary<char, Trie> children;

    public bool flag;
    /** Initialize your data structure here. */
    public Trie()
    {
        children = new Dictionary<char, Trie>();
        flag = false;
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        int index = 0;
        var trie = Find(word, ref index, this);
        Insert(word, index, trie);
    }

    public void Insert(string word, int index, Trie trie)
    {
        if(index == word.Length) 
        {
            trie.flag = true;
            return;
        }
        trie.children[word[index]] = new Trie();
        Insert(word, index+1, trie.children[word[index]]);
    }

    public Trie Find(string word, ref int index, Trie trie)
    {
        if(index == word.Length) return trie;

        Trie tmp;
        if(trie.children.TryGetValue(word[index], out tmp))
        {
            index++;
            return Find(word, ref index ,tmp);
        }
        else
            return trie;
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        int index = 0;
        var trie = Find(word, ref index, this);
        return trie.flag && index == word.Length;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        int index = 0;
        var trie = Find(prefix, ref index, this);
        return index == prefix.Length;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */

