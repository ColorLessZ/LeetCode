public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var p1 = m - 1;
        var p2 = n - 1;
        var p = m + n - 1;
        while (p1 >= 0 && p2 >= 0){
            if (nums1[p1] > nums2[p2]) {
                nums1[p] = nums1[p1];
                p1 -= 1;
                p -= 1;
            } else if (nums1[p1] < nums2[p2]) {
                nums1[p] = nums2[p2];
                p2 -= 1;
                p -= 1;
            } else {
                nums1[p] = nums1[p1];
                nums1[p-1] = nums2[p2];
                p1 -= 1;
                p2 -= 1;
                p -= 2;
            }
        }
        
        if (p1 < 0 && p2 >= 0) {
            for (int i = 0; i <= p2; i++) {
                nums1[i] = nums2[i];
            }
        }
    }
}