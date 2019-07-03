/*
 * @lc app=leetcode id=95 lang=csharp
 *
 * [95] Unique Binary Search Trees II
 *
 * https://leetcode.com/problems/unique-binary-search-trees-ii/description/
 *
 * algorithms
 * Medium (34.98%)
 * Likes:    1226
 * Dislikes: 112
 * Total Accepted:    139.1K
 * Total Submissions: 389.1K
 * Testcase Example:  '3'
 *
 * Given an integer n, generate all structurally unique BST's (binary search
 * trees) that store values 1 ... n.
 * 
 * Example:
 * 
 * 
 * Input: 3
 * Output:
 * [
 * [1,null,3,2],
 * [3,2,null,1],
 * [3,1,null,null,2],
 * [2,1,3],
 * [1,null,2,null,3]
 * ]
 * Explanation:
 * The above output corresponds to the 5 unique BST's shown below:
 * 
 * ⁠  1         3     3      2      1
 * ⁠   \       /     /      / \      \
 * ⁠    3     2     1      1   3      2
 * ⁠   /     /       \                 \
 * ⁠  2     1         2                 3
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
    public IList<TreeNode> GenerateTrees(int n)
    {
        if (n == 0)
            return new List<TreeNode>();

        return GenerateTrees(1, n);
    }

    public IList<TreeNode> GenerateTrees(int start, int end)                     
    {
        IList<TreeNode> res = new List<TreeNode>();
        if(start > end)
        { 
            res.Add(null);
            return res;
        }
        IList<TreeNode> leftChild, rightChild;

        for(int i=start; i<=end; i++)
        {
            leftChild = GenerateTrees(start,i-1);
            rightChild = GenerateTrees(i+1,end);

            foreach (var litem in leftChild)
            {
                foreach (var ritem in rightChild)
                {
                    TreeNode root = new TreeNode(i);
                    root.left = litem;
                    root.right = ritem;
                    res.Add(root);
                }
            }
        }
        return res;
    }
}

