public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int shortIndex = 0;
        int shortestLen = FindShortestStringLength(strs, out shortIndex);
        int prefixLen = 0;
        if (shortestLen > 0)
        {
            for(int i = 1; i <= shortestLen; i++)
            {
                var prefix = strs[shortIndex].Substring(0, i);
                bool fit = true;
                foreach(var s in strs)
                {
                    if (s.IndexOf(prefix) != 0)
                    {
                        fit = false;
                        break;
                    }
                }
                if (fit)
                {
                    prefixLen = i;
                }
            }
            if (prefixLen!=0)
            {
                return strs[shortIndex].Substring(0, prefixLen);
            }
        }
        
        return string.Empty;
    }
    
    private int FindShortestStringLength(string[] strs, out int index)
    {
        if (strs.Length == 0)
        {
            index = -1;
            return 0;
        }
        int shortIndex = 0;
        int shortestLen = strs[0].Length;
        for(int i=0; i< strs.Length; i++)
        {
            if (strs[i].Length < shortestLen)
            {
                shortestLen = strs[i].Length;
                shortIndex = i;
            }
        }
        index = shortIndex;
        return shortestLen;
    }
}