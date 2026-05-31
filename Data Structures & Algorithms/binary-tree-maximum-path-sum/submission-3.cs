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
    private int find(ref int maxi, TreeNode root){
        if(root==null) return 0;
        int left = find(ref maxi, root.left);
        int rig = find(ref maxi, root.right);
        maxi = Math.Max(maxi,root.val+(Math.Max(0,left) + Math.Max(0,rig)));
        return root.val + Math.Max(Math.Max(0,left),Math.Max(0,rig));
    }
    public int MaxPathSum(TreeNode root) {
        int maxi = Int32.MinValue;
        find(ref maxi, root);
        return maxi;
    }
}
