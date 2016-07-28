public class Solution {
    public int LengthOfLastWord(string s) {
        if (s==string.Empty)
        {
            return 0;
        }
        var strArray = s.Split(' ');
        int len = strArray.Length;
        if (len>0){
            for(int i = len-1; i>=0; i--)
            {
                var str = strArray[i];
                if (str.Length > 0 && str[0]!=' ')
                {
                    return strArray[i].Length;
                }
            }
        }
        
        return 0;
    }
}