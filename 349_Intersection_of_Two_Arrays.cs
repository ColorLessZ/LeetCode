public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var dic = new Dictionary<int, bool>();
        var output = new List<int>();
        foreach(var i in nums1)
        {
            dic[i] = true;
        }
        
        foreach(var j in nums2)
        {
            bool exist;
            if(dic.TryGetValue(j, out exist)){
                if (exist){
                    output.Add(j);
                    dic[j] = false;
                }
            }
        }
        
        return output.ToArray();
    }
}