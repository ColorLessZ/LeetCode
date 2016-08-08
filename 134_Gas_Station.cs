public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var len = gas.Length;
        var tank = 0;
        var total = 0;
        var index = -1;
        for (int i = 0; i < len; i++) {
            var val = gas[i] - cost[i];
            tank = tank + val;
            total = total + val;
            
            if (tank < 0) {
                index = i;
                tank = 0;
            } 
        }
        
        return total < 0 ? -1: index + 1;
    }
}