/*
 * @lc app=leetcode id=138 lang=csharp
 *
 * [138] Copy List with Random Pointer
 *
 * https://leetcode.com/problems/copy-list-with-random-pointer/description/
 *
 * algorithms
 * Medium (26.04%)
 * Likes:    1605
 * Dislikes: 429
 * Total Accepted:    252.8K
 * Total Submissions: 920K
 * Testcase Example:  '{"$id":"1","next":{"$id":"2","next":null,"random":{"$ref":"2"},"val":2},"random":{"$ref":"2"},"val":1}'
 *
 * A linked list is given such that each node contains an additional random
 * pointer which could point to any node in the list or null.
 * 
 * Return a deep copy of the list.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * 
 * 
 * Input:
 * 
 * {"$id":"1","next":{"$id":"2","next":null,"random":{"$ref":"2"},"val":2},"random":{"$ref":"2"},"val":1}
 * 
 * Explanation:
 * Node 1's value is 1, both of its next and random pointer points to Node 2.
 * Node 2's value is 2, its next pointer points to null and its random pointer
 * points to itself.
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * You must return the copy of the given head as a reference to the cloned
 * list.
 * 
 * 
 */
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(){}
    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
}
*/
public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if(head == null)
            return null;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node cur = head;
        while(cur!=null)
        {
            map[cur] = new Node(cur.val, null, null);
            cur = cur.next;
        }

        cur = head;
        while(cur!=null)
        {
            if(cur.next != null)
                map[cur].next = map[cur.next];
            else
                map[cur].next = null;
            
            if(cur.random != null)
                map[cur].random = map[cur.random];
            else
                map[cur].random = null;

            cur = cur.next;
        }

        return map[head];
    }
}

