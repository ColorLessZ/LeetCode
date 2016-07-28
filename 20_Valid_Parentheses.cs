public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(char c in s) {
            if (IsOpen(c)) {
                stack.Push(c);
            }
            
            if (IsClose(c)) {
                if (stack.Count == 0) {
                    return false;
                }
                var o = stack.Pop();
                if(!IsPair(c, o)) {
                    return false;
                }
            }
        }
        
        if (stack.Count == 0) {
            return true;
        }
        
        return false;
    }
    
    private bool IsOpen(char c) {
        return (c=='(') || (c=='[') || (c=='{') ;
    }
    
    private bool IsClose(char c) {
        return (c==')') || (c==']') || (c=='}') ;
    }
    
    private bool IsPair(char c, char o) {
        
        if (c == ')') {
            return o=='(';
        } else if (c==']') {
            return o == '[';
        } else if (c=='}') {
            return o == '{';
        }
        
        return false;
    }
}