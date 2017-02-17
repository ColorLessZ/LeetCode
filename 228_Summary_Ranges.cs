public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var list = new List<string>();
        for(int i=0;i<nums.Length;i++){
    	    int a=nums[i];
    	    while(i+1<nums.Length&&(nums[i+1]-nums[i])==1){
    		    i++;
    	    }
    	    if(a!=nums[i]){
    		    list.Add(a+"->"+nums[i]);
    	    }else{
    		    list.Add(a+"");
    	    }   
        }
    return list;
    }
}