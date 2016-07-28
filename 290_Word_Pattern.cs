public class Solution {
    public bool WordPattern(string pattern, string str) {
        var wordsArray = str.Split(' ');
        if (pattern.Length != wordsArray.Length) {
            return false;
        }
        
        var wordDic = new Dictionary<string,string>();
        var patternDic = new Dictionary<string,string>();
        for (int i = 0; i< pattern.Length; i++) {
            var word = wordsArray[i];
            var p = pattern[i].ToString();
            
            if (wordDic.ContainsKey(word)) {
                if (wordDic[word] != p) {
                    return false;
                }
            } else {
                wordDic.Add(word,p);
            }
            
            if (patternDic.ContainsKey(p)) {
                if (patternDic[p] != word) {
                    return false;
                }
            } else {
                patternDic.Add(p,word);
            }
        }
        
        return true;
    }
}