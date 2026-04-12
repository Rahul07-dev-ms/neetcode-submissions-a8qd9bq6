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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode c1 = list1;
        ListNode c2 = list2;
        ListNode ans = new ListNode(-1);
        ListNode temp = ans;
        while(c1 != null && c2 != null){
            if(c1.val > c2.val){
                temp.next = c2;
                c2 = c2.next;
            }
            else{
                temp.next = c1;
                c1 = c1.next;
            }
            temp = temp.next;
        }
        if(c1 != null) temp.next = c1;
        if(c2 != null) temp.next = c2;
        return ans.next;
    }
}