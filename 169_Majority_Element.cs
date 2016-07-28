public class Solution {
    public int MajorityElement(int[] nums) {
        var len = nums.Length;
        var freq = len/2;
        var dic = new Dictionary<int,int>();
        foreach(var num in nums)
        {
            if (dic.ContainsKey(num))
            {
                dic[num]+=1;
            }
            else
            {
                dic.Add(num,1);
            }
        }
        
        foreach(var key in dic.Keys)
        {
            if (dic[key] > freq)
            {
                return key;
            }
        }
        
        return 0;
    }
}