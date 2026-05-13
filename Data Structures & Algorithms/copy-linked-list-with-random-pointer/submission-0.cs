/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
         var curr = head;
        var ans = new Node(-1);
        var temp = ans;
        var map = new Dictionary<Node,Node>();
        int idx = 0;
        while(curr != null){
            var nxt = new Node(curr.val);
            map[curr] = nxt;
            temp.next = nxt;
            temp = temp.next;
            curr = curr.next;
        }
        curr = head;
        idx=0;
        temp = ans.next;
        while(curr != null){
            idx++;
            if(curr.random != null){
                temp.random = map[curr.random];
            }
            curr= curr.next;
            temp = temp.next;
        }
        return ans.next;
    }
}
