/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null) {
            return l2;
        }
        
        if (l2 == null) {
            return l1;
        }
        
        ListNode head1 = l1;
        ListNode head2 = l2;
        ListNode resultHead = new ListNode(0);
        ListNode pivot = new ListNode(0);
        var isFirst = true;
        
        while (head1 != null && head2 !=null) {
            if (isFirst) {
                if (head1.val < head2.val) {
                    resultHead.val = head1.val;
                    head1 = head1.next;
                } else if (head2.val < head1.val) {
                    resultHead.val = head2.val;
                    head2 = head2.next;
                } else {
                    resultHead.val = head1.val;
                    var temp = new ListNode(head2.val);
                    resultHead.next = temp;
                    head1 = head1.next;
                    head2 = head2.next;
                }
                pivot = resultHead.next == null ? resultHead : resultHead.next;
                isFirst = false;
            } else {
                ListNode temp = new ListNode(0);
                if (head1.val < head2.val) {
                    temp.val = head1.val;
                    head1 = head1.next;
                } else if (head2.val < head1.val) {
                    temp.val = head2.val;
                    head2 = head2.next;
                } else {
                    temp.val = head1.val;
                    var temp2 = new ListNode(head2.val);
                    temp.next = temp2;
                    head1 = head1.next;
                    head2 = head2.next;
                }
                pivot.next = temp;
                pivot = temp.next == null ? temp : temp.next;
            }
        }
        
        while (head1 != null) {
            ListNode temp = new ListNode(0);
            temp.val = head1.val;
            pivot.next = temp;
            head1 = head1.next;
            pivot = pivot.next;
        }
        
        while (head2 != null) {
            ListNode temp = new ListNode(0);
            temp.val = head2.val;
            pivot.next = temp;
            head2 = head2.next;
            pivot = pivot.next;
        }
        
        return resultHead;
    }
}