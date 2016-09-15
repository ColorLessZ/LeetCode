public class Solution {
    public char FindTheDifference(string s, string t) {
        int result = 0;
        foreach(char c in s) {
            result = result ^ c;
        }
        
        foreach(char c in t) {
            result = result ^ c;
        }
        
        return Convert.ToChar(result);
    }
}