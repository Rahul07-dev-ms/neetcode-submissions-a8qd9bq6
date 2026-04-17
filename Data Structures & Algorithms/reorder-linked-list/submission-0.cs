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
    public void ReorderList(ListNode head) {
        //step-1
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next!=null){
            slow=slow.next;
            fast = fast.next.next;
        }
        ListNode start2 = slow.next;
        slow.next = null;

        //step-2
        ListNode curr = start2;
        ListNode prev = null;
        ListNode frwd = null;
        while(curr!=null){
            frwd = curr.next;
            curr.next = prev;
            prev = curr;
            curr = frwd;
        }
        //step-3
        ListNode s1 = head;
        ListNode s2 = prev;
        int idx = 0;
        while(s1 != null && s2 != null){
            if(idx%2==0){
                ListNode t = s1.next;
                s1.next = s2;
                s1=t;
            }
            else{
                ListNode t = s2.next;
                s2.next = s1;
                s2=t;
            }
            idx++;
        }
    }
}
