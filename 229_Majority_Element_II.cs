public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var candidate1 = 0;
        var candidate2 = 1;
        var count1 = 0;
        var count2 = 0;
        var list = new List<int>();
        foreach(var num in nums) {
            if (num == candidate1) {
                count1 += 1;
            }else if (num == candidate2) {
                count2 += 1;
            } else if (count1 == 0){
                candidate1 = num;
                count1 = 1;
            } else if (count2 == 0) {
                candidate2 = num;
                count2 = 1;
            } else {
                count1 -= 1;
                count2 -= 1;
            }
        }
        count1 = 0;
        count2 = 0;
        foreach(var num in nums) {
            if (num == candidate1) {
                count1 += 1;
            }
            if (num == candidate2) {
                count2 += 1;
            }
        }
        
        if (count1 > nums.Length/3) {
            list.Add(candidate1);
        }
        if (count2 > nums.Length/3) {
            list.Add(candidate2);
        }

        return list;
    }
}