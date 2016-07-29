/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        var even = head.next;
        var p1 = head;
        var p2 = even;
        while (p1 != null && p2 != null && p1.next != null && p2.next != null){
            p1.next = p2.next;
            p1 = p1.next;
            p2.next = p1.next;
            if (p2.next != null) {
                p2 = p2.next;
            }
        }
        
        p1.next = even;
        p2.next = null;
        return head;
    }
}