public class Solution {
    public int RomanToInt(string s) {
        var romanNum = new Dictionary<char,int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        var len = s.Length;
        int result = romanNum[s[len-1]];
        for(int i =len -2 ; i >= 0; i--){
            var val = romanNum[s[i]];
            var valNext = romanNum[s[i+1]];

            if (val >= valNext) {
                result = result + val;
            } else {
                result = result - val;
            }
        }
        
        return result;
    }
}