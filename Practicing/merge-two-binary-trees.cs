// https://leetcode.com/problems/merge-two-binary-trees/submissions/

// 22.08.09 - 30 min / O(m => minimu number of nodes) / O(h)

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

// refactoring
public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 is null && root2 is null)
            return null;
        if(root1 is null)
            return root2;
        if(root2 is null)
            return root1;
        
        return new TreeNode(
            root1.val + root2.val,
            MergeTrees(root1.left, root2.left),
            MergeTrees(root1.right, root2.right)
        ); 
    }
}

// 22.09.10 => O(n) / O(n)

public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 == null) 
            return root2;

        var queue = new Queue<(TreeNode,TreeNode)>();
        queue.Enqueue((root1, root2));
        
        while(queue.Count > 0)
        {
            var (n1, n2) = queue.Dequeue();
            if(n2 == null) continue;
            
            n1.val += n2.val;
            
            if(n1.left is null) 
                n1.left = n2.left;
            else if(n2.left is not null) 
                queue.Enqueue((n1.left, n2.left));
            
            if(n1.right is null) 
                n1.right = n2.right;
            else if(n2.right is not null)
                queue.Enqueue((n1.right, n2.right));
        }
        
        return root1;
    }
}
