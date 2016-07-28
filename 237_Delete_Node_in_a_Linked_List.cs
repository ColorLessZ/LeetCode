/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var start = node;
        if (start == null)
        {
            return;
        }
        
        while (start != null && start.next != null)
        {
            start.val = start.next.val;
            if (start.next.next == null)
            {
                start.next = null;
            }
            start = start.next;
        }
    }
}