public class Solution {
    public string DecodeString(string s) {
        var numStack = new Stack<int>();
        var stringStack = new Stack<string>();
        string temp = string.Empty;
        string result = string.Empty;
        int i =0;
        int count = 0;
        foreach(var c in s)
        {
            if (c-'0' <= 9 && c-'0' >= 0)
            { 
                count = count*10 + (c -'0');
            } else if (c =='[') {
                stringStack.Push(result);
                numStack.Push(count);
                count = 0;
                result = string.Empty;
            } else if (c == ']') {
                var tmp = result;
                result = stringStack.Pop();
                
                for (count = numStack.Pop(); count > 0; count--)  {
                    result = result + tmp;
                }
            } else {
                result += c;
            }
        }
        return result;
    }
}