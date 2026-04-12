public class Solution {
    private int solve(int[] nums, int idx, int m, int[] dp){
        if(idx >= m){
            return 0;
        }
        if(dp[idx] != -1)return dp[idx];
        int inc = solve(nums,idx+2,m,dp) + nums[idx];
        int exc = solve(nums,idx+1,m,dp);
        return dp[idx] = Math.Max(inc,exc);
    }
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
        int size = nums.Length;
        var dp = new int[size+1];
        Array.Fill(dp,-1);
        int ans1 = solve(nums,0,size-1,dp);
        Array.Fill(dp,-1);
        int ans2 = solve(nums,1,size,dp);
        return Math.Max(ans1,ans2);
    }
}