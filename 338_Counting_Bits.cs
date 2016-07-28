public class Solution {
    public int[] CountBits(int num) {
        var results = new int [num+1];
        int pivot = 1;
        int pow = 1;
        results[0] = 0;
        for(int i=1; i<=num;i++)
        {
            if (i==pow)
            {
                results[i] = 1;
                pow = pow << 1;
                pivot=1;
            }
            else
            {
                results[i] = results[pivot] + 1;
                pivot=pivot+1;
            }
        }
        return results;
    }
}