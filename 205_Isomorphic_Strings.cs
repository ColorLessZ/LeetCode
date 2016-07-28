public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return true;
        }
        
        var dic = new Dictionary<char,char>();
        var dicRev = new Dictionary<char,char>();
        var len = s.Length;
        for(int i=0; i<len; i++)
        {
            var cS = s[i];
            var cT = t[i];
            if (dic.ContainsKey(cS))
            {
                if (dic[cS] != cT)
                {
                    return false;
                }
            }
            else
            {
                dic.Add(cS, cT);
            }
            
            if (dicRev.ContainsKey(cT))
            {
                if (dicRev[cT] != cS)
                {
                    return false;
                }
            }
            else
            {
                dicRev.Add(cT, cS);
            }
        }
        return true;
    }
}