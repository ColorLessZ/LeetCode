public class Solution {
    public bool IsAnagram(string s, string t) {
        var hashSet = new Dictionary<char, int>();
        foreach (char c in s){
            if(hashSet.ContainsKey(c)){
                hashSet[c] += 1; 
            } else {
                hashSet[c] = 1;
            }
        }
        
        foreach (char c in t){
            if(hashSet.ContainsKey(c)) {
                hashSet[c] -= 1;
            } else {
                return false;
            }
        }
        
        foreach(KeyValuePair<char, int> entry in hashSet)
        {
            if (entry.Value != 0){
                return false;
            }
        }
        
        return true;
    }
}