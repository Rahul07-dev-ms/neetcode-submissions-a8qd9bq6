public class Solution {private int solve(int[,] dp,int[] nums,int idx,int prev){
        if(idx == nums.Length) return 0;
        if(dp[idx,prev+1] != -1) return dp[idx,prev+1];
        int len = solve(dp,nums,idx+1,prev);
        if(prev == -1 || nums[prev] < nums[idx]){
            len = Math.Max(len,1 + solve(dp,nums,idx+1,idx));
        }
        
        return  dp[idx,prev+1] = len;
    }
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length+1,nums.Length+1];
        for(int i=0; i<=nums.Length;i++){
            for(int j=0; j<=nums.Length; j++){
                dp[i,j]=-1;
            }
        }
        return solve(dp,nums,0,-1);
    }
}
