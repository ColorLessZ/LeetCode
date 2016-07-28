public class Solution {
    public int TitleToNumber(string s) {
        int sum = 0;
        var len = s.Length;
        for (int i = 0; i < len; i++) {
            char c = s[i];
            sum = sum*26 + c - 'A' + 1;
        }
        
        return sum;
    }
}