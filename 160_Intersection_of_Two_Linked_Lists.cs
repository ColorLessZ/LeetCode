/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lengthA = GetListLength(headA);
        int lengthB = GetListLength(headB);
        
        if (lengthA == lengthB)
        {
            return FindIntersectionNode(headA, headB);
        }
        
        int diff = Math.Abs(lengthA - lengthB);
        if (lengthA > lengthB)
        {
            while(diff!=0)
            {
                headA=headA.next;
                diff--;
            }
        }
        else{
            while(diff!=0)
            {
                headB=headB.next;
                diff--;
            }
        }
        
        return FindIntersectionNode(headA, headB);
    }
    
    private int GetListLength(ListNode head)
    {
        if (head == null)
        {
            return 0;
        }
        
        int length = 1;
        while(head.next!=null)
        {
            length=length+1;
            head=head.next;
        }
        
        return length;
    }
    
    private ListNode FindIntersectionNode(ListNode headA, ListNode headB)
    {
        while (headA!=null && headB!=null)
        {
            if (headA.val==headB.val)
            {
                return headA;
            }
            
            headA = headA.next;
            headB = headB.next;
        }
        return null;
    }
}