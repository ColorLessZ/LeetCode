/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head==null)
        {
            return head;
        }
        
        while(head!=null && head.val==val){
            head = head.next;
        }
        
        var current = head;
        var lastSecond = head;
        
        while(current!=null)
        {
            if(current.next!=null && current.next.val == val)
            {
                current.next = current.next.next;
                continue;
            }
            lastSecond = current;
            current = current.next;
        }
        
        if (current!=null&&current.val == val)
        {
            lastSecond.next= current.next;
        }
        
        return head;
    }
}