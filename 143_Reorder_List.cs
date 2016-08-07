/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null || head.next.next == null ) {
            return;
        }
        
        var preMid = head;
        var p2 = head;
        while(p2.next != null && p2.next.next != null){ 
            preMid = preMid.next;
            p2 = p2.next.next;
        }
        
        ListNode pre = null;
        var curr=preMid.next;
        while(curr != null){
            var next = curr.next;
            curr.next = pre;
            pre = curr;
            curr = next;
        }
        preMid.next = null;
        head = MergeLists(head, pre);
    }
    
    private ListNode MergeLists(ListNode evenHead, ListNode oddHead) {
        var head = evenHead;
        
        while  (oddHead != null && evenHead != null){
            var temp = evenHead.next;
            evenHead.next = oddHead;
            var temp2 = oddHead.next;
            oddHead.next = temp;
            evenHead = temp;
            oddHead = temp2;
        }
        
        if (evenHead != null) {
            evenHead.next = null;
        }
        
        return head;
    }
}