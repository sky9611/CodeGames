/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 *
 * https://leetcode.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (30.73%)
 * Likes:    5365
 * Dislikes: 1378
 * Total Accepted:    906.9K
 * Total Submissions: 2.9M
 * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * You are given two non-empty linked lists representing two non-negative
 * integers. The digits are stored in reverse order and each of their nodes
 * contain a single digit. Add the two numbers and return it as a linked list.
 * 
 * You may assume the two numbers do not contain any leading zero, except the
 * number 0 itself.
 * 
 * Example:
 * 
 * 
 * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
 * Output: 7 -> 0 -> 8
 * Explanation: 342 + 465 = 807.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode(0);
        ListNode cur = res;
        bool flag = false;
        while(l1 != null && l2 != null)
        {
            if(flag)
                cur.next = new ListNode(l1.val + l2.val + 1);
            else
                cur.next = new ListNode(l1.val + l2.val);
            if(cur.next.val >= 10)
            {
                flag = true;
                cur.next.val -= 10;
            }
            else
            {
                flag = false;
            }
            cur = cur.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        var notNull = l1 == null ? l2 : l1;
        while(notNull != null)
        {
            if(flag)
                cur.next = new ListNode(notNull.val + 1);
            else
                cur.next = new ListNode(notNull.val);
            if(cur.next.val >= 10)
            {
                flag = true;
                cur.next.val -= 10;
            }
            else
            {
                flag = false;
            }
            cur = cur.next;
            notNull = notNull.next;
        }
        
        if(flag)
            cur.next = new ListNode(1);
        
        return res.next;
    }
}

