/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var min = 0; 
        var max = n;
        var mid = min;
        while (max >= min){
            mid = min + (max - mid)/2;
            if(IsBadVersion(mid)){
                max = mid -1;
                if (max >= 0) {
                    if (!IsBadVersion(max)){
                        return mid;
                    }
                }
            } else {
                min = mid + 1;
            }
        }
        
        return mid;
    }
}