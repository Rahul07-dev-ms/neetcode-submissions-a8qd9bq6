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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode ans = new ListNode(-1);
        var temp = ans;
        int carry = 0;
        while(l1!=null && l2!=null){
            var dig = l1.val + l2.val + carry;
            carry = dig / 10;
            temp.next = new ListNode(dig % 10);
            temp = temp.next;
            l1=l1.next;
            l2=l2.next;
        }
        while(l1!=null){
            int dig = l1.val + carry;
            carry = dig / 10;
            temp.next = new ListNode(dig % 10);
            temp = temp.next;
            l1=l1.next;            
        }
        while(l2!=null){
            int dig = l2.val + carry;
            carry = dig / 10;
            temp.next = new ListNode(dig % 10);
            temp = temp.next;
            l2=l2.next;            
        }
        if(carry != 0){
            temp.next = new ListNode(carry);
        }
        return ans.next;
    }
}