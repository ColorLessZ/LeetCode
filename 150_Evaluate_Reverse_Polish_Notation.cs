public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<string>();
        foreach(var s in tokens){
            if (s != "+" && s != "-" && s != "*" && s != "/"){
                stack.Push(s);
            } else {
                var num = 0;
                var num1 = Str2Int(stack.Pop());
                var num2 = Str2Int(stack.Pop());
                switch (s) {
                    case "+":
                    num = num2 + num1;
                    break;
                    
                    case "-":
                    num = num2 - num1;
                    break;
                    
                    case "*":
                    num = num2 * num1;
                    break;
                    
                    case "/":
                    num = num2/num1;
                    break;
                }
                
                stack.Push(num.ToString());
            }
        }
        
        return Str2Int(stack.Pop());
    }
    
    private int Str2Int(string s){
        int result;
        if (Int32.TryParse(s, out result)){
            return result;
        }
        return 0;
    }
}