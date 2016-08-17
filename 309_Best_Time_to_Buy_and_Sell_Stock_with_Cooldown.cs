public class Solution {
    public int MaxProfit(int[] prices) {
        var preSell = 0;
        var buy = Int32.MinValue;
        var sell = 0;
        
        foreach (var price in prices) {
            var preBuy = buy;
            buy = Math.Max(preSell - price, buy);
            preSell = sell;
            sell = Math.Max(preBuy + price, preSell);
        }
        
        return sell;
    }
}