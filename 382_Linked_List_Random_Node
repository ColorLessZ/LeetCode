/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
        
    private ListNode listHead;
    private Random random;
    public Solution(ListNode head) {
        listHead = head;
        random = new Random();
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        var count = 1;
        var head = listHead;
        var result = head.val;

        while(head.next != null) {
            head = head.next;
            count = count + 1;
            int randomNumber = random.Next(0, count);
            if (randomNumber == 1) {
                result = head.val;
            }
        }
        
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */