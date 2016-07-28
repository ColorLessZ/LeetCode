/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var node1 = head;
        var node2 = head;
        for (int i = 0; i < n ; i++){
            node2 = node2.next;
        }
        
        while (node2 != null && node2.next != null) {
            node1 = node1.next;
            node2 = node2.next;
        }
        
        if (node2 == null){
            return node1.next;
        }
        
        var temp = node1.next;
        node1.next = temp == null? null : temp.next;
        return head;
    }
}