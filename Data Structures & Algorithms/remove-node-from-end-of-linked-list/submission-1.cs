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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(n == 1 && head.next==null) return head.next;
        int count = 0;
        ListNode temp = head;
        while(temp!=null){
            count++;
            temp=temp.next;
        }
        temp = head;
        int nth = count - n;
        if(count == n)return head.next;
        int idx = 1;
        while(nth != idx){
            temp = temp.next;
            idx++;
        }
        temp.next = temp.next.next;
        return head;
    }
}
