/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
 *
 * https://leetcode.com/problems/reverse-linked-list-ii/description/
 *
 * algorithms
 * Medium (34.22%)
 * Likes:    1255
 * Dislikes: 94
 * Total Accepted:    199K
 * Total Submissions: 565.5K
 * Testcase Example:  '[1,2,3,4,5]\n2\n4'
 *
 * Reverse a linked list from position m to n. Do it in one-pass.
 * 
 * Note: 1 ≤ m ≤ n ≤ length of list.
 * 
 * Example:
 * 
 * 
 * Input: 1->2->3->4->5->NULL, m = 2, n = 4
 * Output: 1->4->3->2->5->NULL
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
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        if( head == null || head.next == null)
            return head;

        ListNode newHead = new ListNode(0);
        newHead.next = head;

        ListNode pre = newHead;
        
        for(int i = 1; i < m; i++)
            pre = pre.next;

        ListNode cur = pre.next;
        ListNode tmp = pre.next.next;
        
        for(int i = 0; i < n-m; i++)
        {
            cur.next = tmp.next;
            tmp.next = pre.next;
            pre.next = tmp;
            tmp = cur.next;
        }

        return newHead.next;
    }
}

