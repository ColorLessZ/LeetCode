/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        
        if (head  == null) {
            return null;
        }
        
        if (head.next == null) {
            return head;
        }
        
        var h1 = head;
        var p1 = head;
        var h2 = head.next;
        var p2 = head.next;
        
        //split list to two lists
        while (p1!=null && p2 != null) {
            p1.next = p2.next;
            
            if (p2.next != null) {
                p2.next = p1.next.next;
            }
            
            p1 = p1.next;
            p2 = p2.next;
        }
        
        //merge two list into 1 list 
        p1=h1;
        p2=h2;
        
        while (p2 != null) {
            var temp = p2.next;
            p2.next = p1;
            var temp2 = p1.next;
            if (temp != null) {
                p1.next = temp;
            }
        
            p2 = temp;
            p1 = temp2;
        }
        
        return h2;
    }
}