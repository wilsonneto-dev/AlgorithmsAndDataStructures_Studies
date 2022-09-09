// https://leetcode.com/problems/merge-two-binary-trees/submissions/

// 22.08.09 - 30 min / O(n) / O(h)

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 is null && root2 is null)
            return null;
        
        return new TreeNode(
            (root1?.val ?? 0) + (root2?.val ?? 0),
            MergeTrees(root1?.left, root2?.left),
            MergeTrees(root1?.right, root2?.right)
        ); 
    }
}
