public class Queue {
    // Push element x to the back of queue.
    private Stack<int> stackIn = new Stack<int>();
    private Stack<int> stackOut = new Stack<int>();
    
    private void MoveInToOut() {
        while(stackIn.Count() != 0){
            stackOut.Push(stackIn.Pop());
        }
    }
    
    public void Push(int x) {
        stackIn.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop() {
        if (stackOut.Count() == 0) {
            MoveInToOut();
        }
        stackOut.Pop();
    }

    // Get the front element.
    public int Peek() {
        if (stackOut.Count() == 0) {
            MoveInToOut();
        }
        
        return stackOut.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return stackIn.Count()==0 && stackOut.Count()==0;
    }
}