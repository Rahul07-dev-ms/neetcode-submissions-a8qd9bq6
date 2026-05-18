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
    private int find(int value, int[] ino, int in_s, int in_e){
        for(int i=in_s; i<= in_e; i++){
            if(ino[i] == value){
                return i;
            }
        }
        return -1;
    }
    private TreeNode BuildNewTree(int[] pre, int[] ino, int in_start, int in_end,ref int pre_idx){
        if(pre_idx >= pre.Length || in_start > in_end){
            return null;
        }
        int index = find(pre[pre_idx++], ino, in_start, in_end);
        var node = new TreeNode(ino[index]);
        node.left = BuildNewTree(pre,ino, in_start, index-1,ref pre_idx);
        node.right = BuildNewTree(pre,ino, index+1 , in_end,ref pre_idx);
        return node;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int i = 0;
        return BuildNewTree(preorder,inorder,0,inorder.Length-1,ref i);
    }
}
