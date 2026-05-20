/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if(root == null){
            return "!";
        }
        string l = Serialize(root.left)  ;
        string r = Serialize(root.right)  ;
        return Convert.ToString(root.val)+ '@' +  l + '@' + r  ;
    }

    // Decodes your encoded data to tree.
    private TreeNode solve(string data, ref int idx){
        if(data[idx]=='@'){
            idx++;
        }
        if(idx >= data.Length || data[idx] == '!'){
            idx++;
            return null;
        } 
        string no = "";
        while(data[idx] != '@'){
            no = no + data[idx++];
        }
        var node = new TreeNode(Convert.ToInt32(no));
        idx++;
        node.left = solve(data,ref idx);
        node.right = solve(data, ref idx);
        return node;
    }
    public TreeNode Deserialize(string data) {
        int idx = 0;
        return solve(data,ref idx);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));