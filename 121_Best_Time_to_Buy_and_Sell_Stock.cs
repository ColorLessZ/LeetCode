public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1) {
            return 0;
        }
        
        int profit = 0;
        int min = prices[0];
        foreach(var p in prices) {
            if (p < min) {
                min = p;
            } else {
                if (p-min > profit){
                    profit = p - min;
                }
            }
        }
        
        return profit;
    }
}