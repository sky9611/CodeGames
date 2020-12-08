/*
 * @lc app=leetcode id=148 lang=csharp
 *
 * [148] Sort List
 *
 * https://leetcode.com/problems/sort-list/description/
 *
 * algorithms
 * Medium (34.21%)
 * Likes:    1508
 * Dislikes: 78
 * Total Accepted:    191.7K
 * Total Submissions: 532.7K
 * Testcase Example:  '[4,2,1,3]'
 *
 * Sort a linked list in O(n log n) time using constant space complexity.
 * 
 * Example 1:
 * 
 * 
 * Input: 4->2->1->3
 * Output: 1->2->3->4
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: -1->5->3->4->0
 * Output: -1->0->3->4->5
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
    // public ListNode SortList(ListNode head)
    // {
    //     if(head == null || head.next == null) return head;
    //     QuickSort(head, null);

    //     return head;
    // }

    // public void QuickSort(ListNode start, ListNode end)
    // {
    //     if(start == end || start.next == end) return;
    //     ListNode index = Partition(start, end);
    //     QuickSort(start, index);
    //     QuickSort(index.next, end);
    // }

    // public ListNode Partition(ListNode start, ListNode end)
    // {
    //     if(start == end || start.next == end) return start;
    //     int e(j != end)
    //     {
    //         if(j.val < pivot)
    //         {
    //             i = i.next;
    //             var tmp = i.val;
    //             i.val = j.val;
    //             j.val = tmp;
    //         }
    //         j = j.next;
    //     }
    //     start.val = i.val;
    //     i.vapivot = start.val;
    //     ListNode i = start, j = start;
    //     whill = pivot;
    //     return i;
    // }

    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var p = head;
        var q = GetMid(head);
        p = SortList(p);
        q = SortList(q);
        return Merge(p, q);
    }

    public ListNode Merge(ListNode p, ListNode q)
    {
        var res = new ListNode(0);
        var tail = res;

        while (p != null && q != null)
        {
            if(p.val <= q.val)
            {
                tail.next = p;
                p = p.next;
            }
            else
            {
                tail.next = q;
                q = q.next;
            }
            tail = tail.next;
            tail.next = null;
        }

        if(p != null) tail.next = p;
        if(q != null) tail.next = q;

        return res.next;
    }

    public ListNode GetMid(ListNode head)
    {
        var prev = head;
        var slow = head.next;
        var fast = head.next;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;

        return slow;
    }
}

