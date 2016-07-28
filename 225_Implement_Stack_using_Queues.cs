public class Stack {
    // Push element x onto stack.
    private Queue<int> queue = new Queue<int>();

    public void Push(int x) {
        queue.Enqueue(x);
        int size = queue.Count;
        for(int i = 0; i < size - 1; i++) {
            queue.Enqueue(queue.Dequeue());
        }
    }

    // Removes the element on top of the stack.
    public void Pop() {
        queue.Dequeue();
    }

    // Get the top element.
    public int Top() {
        return queue.Peek();
    }

    // Return whether the stack is empty.
    public bool Empty() {
        return queue.Count == 0;
    }
}