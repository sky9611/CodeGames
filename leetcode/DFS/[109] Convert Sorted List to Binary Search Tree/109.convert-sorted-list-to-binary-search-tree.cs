/*
 * @lc app=leetcode id=109 lang=csharp
 *
 * [109] Convert Sorted List to Binary Search Tree
 *
 * https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/description/
 *
 * algorithms
 * Medium (39.82%)
 * Total Accepted:    167.6K
 * Total Submissions: 420K
 * Testcase Example:  '[-10,-3,0,5,9]'
 *
 * Given a singly linked list where elements are sorted in ascending order,
 * convert it to a height balanced BST.
 * 
 * For this problem, a height-balanced binary tree is defined as a binary tree
 * in which the depth of the two subtrees of every node never differ by more
 * than 1.
 * 
 * Example:
 * 
 * 
 * Given the sorted linked list: [-10,-3,0,5,9],
 * 
 * One possible answer is: [0,-3,9,-10,null,5], which represents the following
 * height balanced BST:
 * 
 * ⁠     0
 * ⁠    / \
 * ⁠  -3   9
 * ⁠  /   /
 * ⁠-10  5
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    private ListNode head;
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null) return null;

        # region SpaceTrade
        // List<TreeNode> list = new List<TreeNode>();
        // while (head != null)
        // {
        //     list.Add(new TreeNode(head.val));
        //     head = head.next;
        // }

        // return Foo(list, 0, list.Count-1);
        # endregion

        # region inorder simulation
        this.head = head;
        int length = 0;
        while(head!=null)
        {
            length++;
            head = head.next;
        }

        return InOrderBst(0, length-1);
        # endregion
    }

    private TreeNode InOrderBst(int start, int end)
    {
        if (start > end) return null;
        int mid = (start + end) / 2;
        TreeNode left = InOrderBst(start, mid-1);
        TreeNode node = new TreeNode(this.head.val);
        node.left = left;
        this.head = this.head.next;
        node.right = InOrderBst(mid+1, end);

        return node;
    }

    private TreeNode Foo(List<TreeNode> list, int start, int end)
    {
        if (start > end) return null;
        int mid = (end + start)/2;
        TreeNode node = list[mid];
        node.left = Foo(list, start, mid-1);
        node.right = Foo(list, mid+1, end);
        return node;
    }
}

