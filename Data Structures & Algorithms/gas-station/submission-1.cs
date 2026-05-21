public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum()) return -1;
        int fuel = 0;
        int idx = 0;
        for(int i=0; i<gas.Length; i++){
            fuel = fuel + gas[i];
            fuel = fuel - cost[i];
            if(fuel < 0){
                fuel = 0;
                idx = i+1;
            }
        }
        return idx;
    }
}