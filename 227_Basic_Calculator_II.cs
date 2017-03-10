public class Solution {
    public int Calculate(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var numStack = new Stack<int>();
        var num = 0;
        var op = '+';
        for(int i = 0; i < s.Length; i++) {
            var val = s[i];
            if (val - '0' >=0 && val -'0' <= 9) {
                num = num*10 + val - '0';
            } 
            
            if ((!(val - '0' >= 0 && val -'0' <= 9) && val != ' ') || i == s.Length -1){
                if (op == '+') {
                    numStack.Push(num);
                }
                
                if (op == '-') {
                    numStack.Push(num*-1);
                }
                
                if (op == '*') {
                    numStack.Push(numStack.Pop()*num);
                }
                
                if (op == '/') {
                    numStack.Push(numStack.Pop()/num);
                }
                
                op = val;
                num = 0;
            }
        }
        
        var result = 0;
        while(numStack.Count != 0) {
            result = result + numStack.Pop();
        }
        
        return result;
    }
}