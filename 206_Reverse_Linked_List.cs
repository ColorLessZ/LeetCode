/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode previous = null;
        var current = head;
        var next = head;
        while(current!=null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
      
    }
}