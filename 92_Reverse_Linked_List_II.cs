/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        var count = 0;
        var dummy = new ListNode(0);
        dummy.next = head;
        var pre = dummy;
        while (count < m - 1) {
            pre = pre.next;
            count += 1;
        }
        
        var start = pre.next;
        var then = start.next;
        for(int i=0; i<n-m; i++)
        {
            start.next = then.next;
            then.next = pre.next;
            pre.next = then;
            then = start.next;
        }
        
        return dummy.next;
    }
}