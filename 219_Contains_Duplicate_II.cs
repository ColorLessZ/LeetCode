public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var len = nums.Length;
        if (len <= 0)
        {
            return false;
        }
        var dic = new Dictionary<int,List<int>>();
        for(int i = 0; i < len; i++)
        {
            var value = nums[i];
            if (dic.ContainsKey(value))
            {
                dic[value].Add(i);
            }
            else
            {
                var dicValue = new List<int>();
                dicValue.Add(i);
                dic.Add(nums[i],dicValue);
            }
        }
        foreach(var item in dic)
        {
           var value = item.Value;
           if (ContainDup(value,k))
           {
               return true;
           }
        }
        return false;
    }
    
    private bool ContainDup(List<int> index, int k)
    {
        var len = index.Count;
        for (int i=0; i<len-1; i++)
        {
            if (index[i+1]-index[i]<=k)
            {
                return true;
            }
        }
        return false;
    }
}