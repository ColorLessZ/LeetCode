/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        var stack = new Stack<ListNode>();
        var queue = new Queue<ListNode>();
        while(head!=null){
            stack.Push(head);
            queue.Enqueue(head);
            head = head.next;
        }
        
        while(queue.Count != 0 && stack.Count != 0){
            var q = queue.Dequeue();
            var s = stack.Pop();
            if(q.val != s.val) {
                return false;
            }
        }
        
        return true;
    }
}