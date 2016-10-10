public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var hash = new Dictionary<char, int>();
        foreach (var c in magazine) {
            if (hash.ContainsKey(c)) {
                hash[c] += 1;
            } else {
                hash[c] = 1; 
            }
        }
        
        foreach(var c in ransomNote) {
            if (!hash.ContainsKey(c)) {
                return false;
            } else {
                if (hash[c] == 0) {
                    return false;
                } else {
                    hash[c] -= 1;
                }
            }
        }
        
        return true;
    }
}