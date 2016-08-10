/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        if (head == null) {
            return head;
        }
        
        var small = new ListNode(0);
        var big = new ListNode(0);
        var smallHead = small;
        var bigHead = big;
        
        while (head != null) {
            var val = head.val;
            if (val < x) {
                small.next = head;
                small = small.next;
            } else {
                big.next = head;
                big = big.next;
            }
            
            head = head.next;
        }
        
        big.next = null;
        small.next = bigHead.next;
        
        return smallHead.next;
    }
}