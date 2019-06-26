/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 *
 * https://leetcode.com/problems/reverse-linked-list/description/
 *
 * algorithms
 * Easy (53.18%)
 * Likes:    2409
 * Dislikes: 64
 * Total Accepted:    609K
 * Total Submissions: 1.1M
 * Testcase Example:  '[1,2,3,4,5]'
 *
 * Reverse a singly linked list.
 * 
 * Example:
 * 
 * 
 * Input: 1->2->3->4->5->NULL
 * Output: 5->4->3->2->1->NULL
 * 
 * 
 * Follow up:
 * 
 * A linked list can be reversed either iteratively or recursively. Could you
 * implement both?
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
    public ListNode ReverseList(ListNode head)
    {
        // if(head == null)
        //     return null;
        // List<ListNode> list = new List<ListNode>();
        // ListNode cur = head;
        // while(cur != null)
        // {
        //     list.Add(cur);
        //     cur = cur.next;
        // }

        // for(int i = list.Count() - 1; i > 0; i--)
        //     list[i].next = list[i-1];
        
        // head.next = null;

        if(head == null || head.next == null)
            return head;
        
        ListNode pre = head;
        ListNode cur = head.next;
        ListNode tmp = head;

        while(cur != null)
        {
            pre.next = cur.next;
            cur.next = tmp;
            tmp = cur;
            cur = pre.next;
        }

        return tmp;
    }
}

