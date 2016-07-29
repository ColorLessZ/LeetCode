public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var numHash = new HashSet<int>();
        foreach(var num in nums)
        {
            if (numHash.Contains(num))
            {
                return true;
            }
            else
            {
                numHash.Add(num);
            }
        }
        
        return false;
    }
}