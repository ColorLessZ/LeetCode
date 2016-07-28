/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var node = head;
        while (node != null && node.next != null) {
            if (node.val == node.next.val){
                node.next = node.next.next;
            } else {
                node = node.next;
            }
        }
        
        return head;
    }
}