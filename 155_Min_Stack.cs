public class MinStack {
    
    public class Node {
        public Node next;
        public int value;
        public int min;
        public Node(int x)
        {
            this.next = null;
            this.min=x;
            this.value =x;
        }
    }
    
    private Node head = null;
    
    public void Push(int x) {
        var node = new Node(x);

        if (head != null){
            node.min = Math.Min(x, GetMin());
        }
        node.next = head;
        head = node;
    }

    public void Pop() {
        if (head != null)
        {
            head = head.next;
        }
    }

    public int Top() {
        return head.value;
    }

    public int GetMin() {
        return head.min;
    }
}