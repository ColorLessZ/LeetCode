public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        var result = string.Empty;
        foreach(var word in d) {
            int i = 0;
            foreach(var c in s) {
                if (i < word.Length && c == word[i]) {
                    i += 1;
                }
            }
            
            if (i == word.Length) {
                if (result.Length < word.Length) {
                    result = word;
                } else if (result.Length == word.Length) {
                    if (String.Compare(word,result) < 0) {
                        result = word;
                    }
                }
            }
        }
        
        return result;
    }
}