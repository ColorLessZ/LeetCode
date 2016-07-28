public class Solution {
    public int StrStr(string haystack, string needle) {
        var stackLen = haystack.Length;
        var needleLen = needle.Length;
        
        var delta = stackLen - needleLen;
        if (delta < 0) {
            return -1;
        }
        
        if (stackLen == 0 || needleLen == 0) {
            return 0;
        }
        
        for (int i = 0; i <= delta; i++) {
            for (int j = 0; j < needleLen; j++) {
                if (haystack[i + j] != needle[j]) {
                    break;
                }
                
                if (j == needleLen - 1) {
                    return i;
                }
            }
        }
        
        return -1;
    }
}