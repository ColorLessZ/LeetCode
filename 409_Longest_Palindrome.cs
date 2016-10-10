public class Solution {
    public int LongestPalindrome(string s) {
        var hash = new HashSet<char>();
        var count = 0;
        foreach(var c in s){
            if (hash.Contains(c)){
                hash.Remove(c);
                count += 1;
            } else {
                hash.Add(c);
            }
        }
        
        if (hash.Count != 0) {
            return count*2 + 1;
        }
        return count*2;
        
    }
}