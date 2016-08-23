public class Solution {
    public int FirstUniqChar(string s) {
        var hash = new Dictionary<char, bool> ();
        foreach (var c in s) {
            if (hash.ContainsKey(c)) {
                hash[c] = false;
            } else {
                hash[c] = true;
            }
        }
        
        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            if (hash[c]) {
                return i;
            }
        }
        
        return -1;
    }
}