public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dic = new Dictionary<int, int>();
        var output = new List<int>();
        foreach(var i in nums1)
        {
            int count;
            if(dic.TryGetValue(i, out count)){
                dic[i] = count + 1;
            }
            else{
                dic[i] = 1;
            }
        }
        
        foreach(var j in nums2)
        {
            int count;
            if(dic.TryGetValue(j, out count)){
                if (count != 0){
                    output.Add(j);
                    dic[j] = count - 1;
                }
            }
        }
        
        return output.ToArray();
    }
}