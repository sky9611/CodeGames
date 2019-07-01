/*
 * @lc app=leetcode id=173 lang=csharp
 *
 * [173] Binary Search Tree Iterator
 *
 * https://leetcode.com/problems/binary-search-tree-iterator/description/
 *
 * algorithms
 * Medium (47.46%)
 * Likes:    1397
 * Dislikes: 246
 * Total Accepted:    209.5K
 * Total Submissions: 427.2K
 * Testcase Example:  '["BSTIterator","next","next","hasNext","next","hasNext","next","hasNext","next","hasNext"]\n[[[7,3,15,null,null,9,20]],[null],[null],[null],[null],[null],[null],[null],[null],[null]]'
 *
 * Implement an iterator over a binary search tree (BST). Your iterator will be
 * initialized with the root node of a BST.
 * 
 * Calling next() will return the next smallest number in the BST.
 * 
 * 
 * 
 * 
 * 
 * 
 * Example:
 * 
 * 
 * 
 * 
 * BSTIterator iterator = new BSTIterator(root);
 * iterator.next();    // return 3
 * iterator.next();    // return 7
 * iterator.hasNext(); // return true
 * iterator.next();    // return 9
 * iterator.hasNext(); // return true
 * iterator.next();    // return 15
 * iterator.hasNext(); // return true
 * iterator.next();    // return 20
 * iterator.hasNext(); // return false
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * next() and hasNext() should run in average O(1) time and uses O(h) memory,
 * where h is the height of the tree.
 * You may assume that next() call will always be valid, that is, there will be
 * at least a next smallest number in the BST when next() is called.
 * 
 * 
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
public class BSTIterator {

    IList<int> list;
    int index;
    public BSTIterator(TreeNode root) {
        list = InorderTraversal(root);
        index = 0;
    }
    
    /** @return the next smallest number */
    public int Next() {
        return list[index++];
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return index < list.Count();
    }

    private IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> ans = new List<int>();
        Helper(root, ans);
        return ans;
    }

    private void Helper(TreeNode root, IList<int> ans)
    {
        if(root!=null)
        {
            Helper(root.left, ans);
            ans.Add(root.val);
            Helper(root.right, ans);
        }
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */

