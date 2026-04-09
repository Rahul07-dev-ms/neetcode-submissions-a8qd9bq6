public class Solution {
    private bool solve(int[,] dp,int[] arr, int sum, int idx){
        if(idx == arr.Length) return false;
        if(sum < 0) return false;
        if(dp[idx,sum] != -1){
            return dp[idx,sum]==1 ? true : false;
        }
        if(sum == 0) {
            dp[idx,sum]=1;
            return true;
        }
        bool inc = solve(dp,arr,sum-arr[idx],idx+1);
        if(inc){
            dp[idx,sum] = 1;
            return true;
        }
        bool exc = solve(dp,arr,sum,idx+1);
        bool ans = exc || inc;
        if(ans){
            dp[idx,sum] = 1;
            return true;
        }
        dp[idx,sum] = 0;
        return false;
    }
    public bool CanPartition(int[] nums) {        
        int sum = 0;
        foreach(int e in nums) sum+=e;
        if(sum % 2 != 0) return false;
        sum = sum/2;
        var dp = new int[nums.Length,sum+1];
        for(int i=0; i<nums.Length; i++){
            for(int j=0; j<=sum;j++){
                dp[i,j] = -1;
            }
        }
        return solve(dp, nums,sum, 0);
    }
}