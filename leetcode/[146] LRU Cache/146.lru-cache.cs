/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 *
 * https://leetcode.com/problems/lru-cache/description/
 *
 * algorithms
 * Hard (24.36%)
 * Likes:    3032
 * Dislikes: 104
 * Total Accepted:    308.2K
 * Total Submissions: 1.2M
 * Testcase Example:  '["LRUCache","put","put","get","put","get","put","get","get","get"]\n[[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]'
 *
 * Design and implement a data structure for Least Recently Used (LRU) cache.
 * It should support the following operations: get and put.
 * 
 * get(key) - Get the value (will always be positive) of the key if the key
 * exists in the cache, otherwise return -1.
 * put(key, value) - Set or insert the value if the key is not already present.
 * When the cache reached its capacity, it should invalidate the least recently
 * used item before inserting a new item.
 * 
 * The cache is initialized with a positive capacity.
 * 
 * Follow up:
 * Could you do both operations in O(1) time complexity?
 * 
 * Example:
 * 
 * 
 * LRUCache cache = new LRUCache( 2);
 * 
 * cache.put(1, 1);
 * cache.put(2, 2);
 * cache.get(1);       // returns 1
 * cache.put(3, 3);    // evicts key 2
 * cache.get(2);       // returns -1 (not found)
 * cache.put(4, 4);    // evicts key 1
 * cache.get(1);       // returns -1 (not found)
 * cache.get(3);       // returns 3
 * cache.get(4);       // returns 4
 * 
 * 
 * 
 * 
 */
public class LRUCache {

    private Dictionary<int, int> dict;
    private int n;
    LinkedList<int> list;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, int>();
        n = capacity;
        list = new LinkedList<int>();
    }
    
    public int Get(int key) {
        int ans;
        if(dict.TryGetValue(key, out ans))
        {
            list.Remove(key);
            list.AddFirst(key);
            return ans;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        
        int pre = dict.Count();
        dict[key] = value;
        if(dict.Count() != pre)
        {
            if(dict.Count()>n)
            {
                // Console.WriteLine(n + " " + dict.Count() + " " + key + " " + value);
                int remove = list.Last.Value;
                dict.Remove(remove);
                list.RemoveLast();
            }
        }
        else
        {
            list.Remove(key);
        }

        list.AddFirst(key);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */

