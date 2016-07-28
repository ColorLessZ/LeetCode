/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null || head.next.next ==null) {
            return false;
        }
        var p1 = head.next;
        var p2 = head.next.next;
        
        while (p1!=p2) {
            p1=p1.next;
            if(p2==null || p2.next == null) {
                return false;
            } else {
                p2=p2.next.next;
            }
            
        }
        
        return true;
    }
}