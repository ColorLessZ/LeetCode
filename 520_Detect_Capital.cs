public class Solution {
    public bool DetectCapitalUse(string word) {
        bool allUpper = false;
        if (char.IsUpper(word[0])) {
            allUpper = true;
        }
        for(int i = 1; i < word.Length; i++) {
            var c = word[i];
            if (char.IsUpper(c)) {
                if (!allUpper){
                    return false;
                }
            } else {
                if (i != 1) {
                    if (allUpper) {
                        return false;
                    }
                } else {
                    allUpper = false;
                }
            }
        }
        
        return true;
    }
}