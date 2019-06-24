/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 *
 * https://leetcode.com/problems/merge-k-sorted-lists/description/
 *
 * algorithms
 * Hard (33.32%)
 * Likes:    2547
 * Dislikes: 168
 * Total Accepted:    402.2K
 * Total Submissions: 1.2M
 * Testcase Example:  '[[1,4,5],[1,3,4],[2,6]]'
 *
 * Merge k sorted linked lists and return it as one sorted list. Analyze and
 * describe its complexity.
 * 
 * Example:
 * 
 * 
 * Input:
 * [
 * 1->4->5,
 * 1->3->4,
 * 2->6
 * ]
 * Output: 1->1->2->3->4->4->5->6
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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if(lists.Count() == 0)
            return null;
        
        int hi = lists.Length - 1;
        int lo = 0;
        
        while(lo < hi)
        {
            int mid = (lo + hi) / 2;
            while(lo < hi)
            {
                lists[lo] = MergeTwoLists(lists[lo], lists[hi]);
                lo++;
                hi--;
            }
            lo = 0;
            hi = mid;
        }

        return lists[0];

        // ListNode res = null;
        // for(int i = 0; i < lists.Count(); i++)
        // {
        //     res = MergeTwoLists(res, lists[i]);
        // }
        // return res;
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode(0);
        ListNode cur = res;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                cur.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                cur.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            cur = cur.next;
        }

        cur.next = l1 == null ? l2 : l1;
        return res.next;
    }
}

