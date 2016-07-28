public class Solution {
    public bool IsPalindrome(string s) {
        var lower = s.ToLower();
        var len = lower.Length;
        var start = 0;
        var end = len -1;
        while (start <= end) {
            var c1 = lower[start];
            var c2 = lower[end];
            if (!IsLowerLetter(c1)) {
                start++;
            }
            
            if (!IsLowerLetter(c2)) {
                end--;
            }
            
            if (IsLowerLetter(c1) && IsLowerLetter(c2)) {
                if (c1 == c2) {
                    start++;
                    end--;
                } else {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    private bool IsLowerLetter(char c) {
        return ((c >= 'a') && (c <= 'z')) || ((c >= '0') && ( c <= '9'));
    }
}