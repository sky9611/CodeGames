/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
 *
 * https://leetcode.com/problems/reverse-nodes-in-k-group/description/
 *
 * algorithms
 * Hard (35.59%)
 * Likes:    1218
 * Dislikes: 256
 * Total Accepted:    190.5K
 * Total Submissions: 516.7K
 * Testcase Example:  '[1,2,3,4,5]\n2'
 *
 * Given a linked list, reverse the nodes of a linked list k at a time and
 * return its modified list.
 * 
 * k is a positive integer and is less than or equal to the length of the
 * linked list. If the number of nodes is not a multiple of k then left-out
 * nodes in the end should remain as it is.
 * 
 * 
 * 
 * 
 * Example:
 * 
 * Given this linked list: 1->2->3->4->5
 * 
 * For k = 2, you should return: 2->1->4->3->5
 * 
 * For k = 3, you should return: 3->2->1->4->5
 * 
 * Note:
 * 
 * 
 * Only constant extra memory is allowed.
 * You may not alter the values in the list's nodes, only nodes itself may be
 * changed.
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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if(head == null || head.next == null) return head;
        var res = new ListNode(0);
        res.next = head;
        ListNode pre = res;
        ListNode left = head;
        ListNode right = head.next;
        ListNode checkNode = head;

        while(true)
        {
            for(int i = 0; i < k; i++)
            {
                if(checkNode == null)
                {
                    return res.next;
                }
                checkNode = checkNode.next;
            }

            for(int i = 0; i < k-1; i++)
            {
                left.next = right.next;
                right.next = pre.next;
                pre.next = right;
                right = left.next;
            }

            pre = left;
            left = right;

            if(right == null){
                return res.next;
            }else{
                right = right.next;
            }
        }
    }
}

