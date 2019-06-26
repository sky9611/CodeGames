/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 *
 * https://leetcode.com/problems/palindrome-linked-list/description/
 *
 * algorithms
 * Easy (35.47%)
 * Likes:    1696
 * Dislikes: 251
 * Total Accepted:    267.7K
 * Total Submissions: 737.6K
 * Testcase Example:  '[1,2]'
 *
 * Given a singly linked list, determine if it is a palindrome.
 * 
 * Example 1:
 * 
 * 
 * Input: 1->2
 * Output: false
 * 
 * Example 2:
 * 
 * 
 * Input: 1->2->2->1
 * Output: true
 * 
 * Follow up:
 * Could you do it in O(n) time and O(1) space?
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
    public bool IsPalindrome(ListNode head)
    {
        if(head == null || head.next == null)
            return true;;

        ListNode pre = head;
        ListNode last = head.next;
        while(last != null && last.next!=null)
        {
            pre = pre.next;
            last = last.next.next;
        }

        ListNode newHead = ReverseList(pre.next);
        while(newHead!=null)
        {
            if(newHead.val != head.val)
                return false;
            newHead = newHead.next;
            head = head.next;
        }
        return true;
    }

    public ListNode ReverseList(ListNode head)
    {        
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

