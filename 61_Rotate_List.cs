/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k==0) {
            return head;
        }
        
        var len = 1;
        var tail = head;
        while (tail.next != null) {
            len += 1;
            tail = tail.next;
        }
        
        ////circle the list
        tail.next = head;
        var count = k % len;
        int i = 0;
        while (i < len - count) {
            tail=tail.next;
            i++;
        }
        
        var newHead = tail.next;
        tail.next = null;
        
        return newHead;
    }
}