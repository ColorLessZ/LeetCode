public class Solution {
    private Dictionary<int,int> amountDic = new Dictionary<int,int>();
    public int CoinChange(int[] coins, int amount) {
        if (amount == 0){
            return 0;
        }
        if (amountDic.ContainsKey(amount)) {
            return amountDic[amount];
        }
        var minCoin = amount + 1;
        foreach(var coin in coins) {
            var curr = 0;
            if (coin <= amount) {
                var comming = CoinChange(coins, amount - coin);
                if (comming >= 0){
                    curr = comming + 1;
                }
                if (curr > 0) {
                    minCoin = Math.Min(minCoin, curr);
                }
            }
        }
        amountDic.Add(amount, minCoin >= amount + 1 ? -1 : minCoin);
        return minCoin >= amount + 1 ? -1 : minCoin;
        
    }
}