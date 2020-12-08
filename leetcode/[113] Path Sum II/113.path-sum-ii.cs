/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
 *
 * https://leetcode.com/problems/path-sum-ii/description/
 *
 * algorithms
 * Medium (39.69%)
 * Total Accepted:    218.8K
 * Total Submissions: 549.7K
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,5,1]\n22'
 *
 * Given a binary tree and a sum, find all root-to-leaf paths where each path's
 * sum equals the given sum.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given the below binary tree and sum = 22,
 * 
 * 
 * ⁠     5
 * ⁠    / \
 * ⁠   4   8
 * ⁠  /   / \
 * ⁠ 11  13  4
 * ⁠/  \    / \
 * 7    2  5   1
 * 
 * 
 * Return:
 * 
 * 
 * [
 * ⁠  [5,4,11,2],
 * ⁠  [5,8,4,5]
 * ]
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
public class Solution
{
    
    List<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        if (root == null) return res;
        Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new Tuple<TreeNode, int>(root, root.val));
        List<int> curList = new List<int>();

        Foo(root, sum, curList);

        return res;
        // bool flag = false;
        // while(stack.Count>0)
        // {
        //     Tuple<TreeNode, int> tuple = stack.Pop();
        //     TreeNode node = tuple.Item1;
        //     int n = tuple.Item2;
        //     curList.Add(node.val); 
        //     if (node.left!=null)
        //         stack.Push(new Tuple<TreeNode, int>(node.left, node.left.val + n));
        //     if (node.right!=null)
        //         stack.Push(new Tuple<TreeNode, int>(node.right, node.right.val + n));
        //     if (node.left == null && node.right == null)
        //     {
        //         if (n == sum)
        //         {
        //             res.Add(new List<int>(curList));
                    
        //         }
        //     }
        //     curList.RemoveAt(curList.Count-1);
        // }
        // return res;
    }

    private void Foo(TreeNode node, int sum, List<int> curList)
    {
        if (node == null) return;
        if (node.val == sum)
        {
            if (node.left == null && node.right == null)
            {
                curList.Add(node.val);
                res.Add(new List<int>(curList));
                curList.RemoveAt(curList.Count-1);
            }
        }
        curList.Add(node.val);
        Foo(node.left, sum-node.val, curList);
        Foo(node.right, sum-node.val, curList);
        curList.RemoveAt(curList.Count-1);
    }
}

