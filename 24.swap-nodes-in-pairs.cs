/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
 *
 * https://leetcode.com/problems/swap-nodes-in-pairs/description/
 *
 * algorithms
 * Medium (43.53%)
 * Likes:    1185
 * Dislikes: 105
 * Total Accepted:    324.3K
 * Total Submissions: 719.3K
 * Testcase Example:  '[1,2,3,4]'
 *
 * Given a linked list, swap every two adjacent nodes and return its head.
 * 
 * You may not modify the values in the list's nodes, only nodes itself may be
 * changed.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Given 1->2->3->4, you should return the list as 2->1->4->3.
 * 
 * 
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode ans = new ListNode(0);
        ans.next = head;
        ListNode pre = ans;
        ListNode first;
        while(pre != null)
        {
            if(pre.next == null || pre.next.next == null) break;

            first = pre.next;
            pre.next = first.next;
            first.next = first.next.next;
            pre.next.next = first;
            pre = first;
        }

        return ans.next;
    }
}

