/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var pq = new PriorityQueue<ListNode,int>();
        for(int i=0; i<lists.Length;i++){
            if(lists[0] == null){continue;}
            pq.Enqueue((lists[i]),lists[i].val);
        }
        ListNode ans = new ListNode(-1);
        ListNode temp = ans;
        while(pq.Count > 0){
            var node = pq.Dequeue();
            temp.next = node;
            temp=temp.next;
            if(node.next != null){
                pq.Enqueue(node.next,node.next.val);
            }
        }
        return ans.next;
    }
}