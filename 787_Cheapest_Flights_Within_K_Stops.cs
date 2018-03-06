public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        var cost = new int[n,K+1];
        
        //Fill the array with Int32.MaxValue        
        for (int i = 0; i < cost.GetLength(0); ++i)
        {
             for (int j = 0; j < cost.GetLength(1); ++j){
                 cost[i, j] = Int32.MaxValue;
             }
        }
        
        cost[src,0] = 0;
        //update direct flight
        foreach(var f in flights){
            if (f[0] == src) {
                cost[f[1],0] = f[2];
            }
        }
        
        //start update rules:
        for(int i = 1; i <= K; i++){
            //make cost[i,j] the same as cost[i,j-1] first
            for(int j = 0; j<n; j++){
                cost[j,i] = cost[j, i-1];
            }
            
            //update based on flights
            foreach(var f in flights){
                if (cost[f[0], i-1] == Int32.MaxValue){
                    cost[f[1], i] = cost[f[1], i];
                }
                else{
                    cost[f[1], i] = Math.Min(cost[f[1], i], cost[f[0], i-1] + f[2]);
                }
            }
        }
        
        return cost[dst, K] == Int32.MaxValue ? -1 : cost[dst, K];
    }
}