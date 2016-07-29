public class Solution {
    public string Convert(string s, int numRows) {
        string r = string.Empty;
        var len = s.Length;
        if (len<=numRows || numRows == 1){
            return s;
        }

        for(int i=0; i<numRows; i++){
            var j = i;
            var toggle = true;
            while (j <= len-1){
                if (i == 0 || i == numRows - 1) {
                    r = r + s[j];
                    j = j + (numRows - 1) * 2;
                } else {
                    r = r + s[j];
                    if (toggle) {
                        j = j + (numRows - 1 - i) * 2;
                    } else {
                        j = j + 2 * i;
                    }
                    toggle = !toggle;
                }
            }
        }
        
        return r;
    }
}