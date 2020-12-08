/*
 * @lc app=leetcode id=82 lang=csharp
 *
 * [82] Remove Duplicates from Sorted List II
 *
 * https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/description/
 *
 * algorithms
 * Medium (32.34%)
 * Likes:    854
 * Dislikes: 74
 * Total Accepted:    186.1K
 * Total Submissions: 559.2K
 * Testcase Example:  '[1,2,3,3,4,4,5]'
 *
 * Given a sorted linked list, delete all nodes that have duplicate numbers,
 * leaving only distinct numbers from the original list.
 * 
 * Example 1:
 * 
 * 
 * Input: 1->2->3->3->4->4->5
 * Output: 1->2->5
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 1->1->1->2->3
 * Output: 2->3
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null ) return head;
        var res = new ListNode(0);
        res.next = head;
        var pre = res;
        var cur = head.next;
        while(cur != null)
        {
            bool dup = false;
            while(cur != null && pre.next.val==cur.val)
            {
                dup = true;
                cur = cur.next;
            }
            if(dup || cur == null) 
            {
                pre.next = cur;
            }
            else
            {
                pre = pre.next;
            }
            if(cur!=null) cur = cur.next;
        }
        return res.next;
    }
}

