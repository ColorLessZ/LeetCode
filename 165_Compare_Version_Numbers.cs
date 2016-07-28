public class Solution {
    public int CompareVersion(string version1, string version2) {
        var version1Array = version1.Split('.');
        var version2Array = version2.Split('.');
        var minLen = Math.Min(version1Array.Length, version2Array.Length);
        var maxLen = Math.Max(version1Array.Length, version2Array.Length);
        
        for (int i = 0; i < minLen; i++){
            var v1 = Int32.Parse(version1Array[i]);
            var v2 = Int32.Parse(version2Array[i]);
            if (v1 > v2){
                return 1;
            } else if (v1 < v2){
                return -1;
            }
        }
        
        if (minLen == maxLen) {
            return 0;
        }
        var temp = version1Array;
        if (version1Array.Length < version2Array.Length)
        {
            temp = version2Array;
        }
        
        for(int i=minLen; i<maxLen; i++) {
            var v = Int32.Parse(temp[i]);
            if (v != 0){
                return version1Array.Length > version2Array.Length ? 1 : -1;
            }
        }
        
        return 0;
    }
}