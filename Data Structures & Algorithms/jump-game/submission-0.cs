public class Solution {
    private bool solve(int[] arr, int idx, int[] dp){
        if(idx >= arr.Length-1){
            return true;
        }
        if(dp[idx] != -1){
            return dp[idx]==0?false:true;
        }
        bool ans = false;
        for(int i=idx+1; i<=idx+arr[idx]; i++){
            ans =  solve(arr,i,dp);
            if(ans) break;
        }
        if(ans) dp[idx]=1;
        else dp[idx]=0;
        return ans;
    }
    public bool CanJump(int[] nums) {
        int[] dp = new int[nums.Length+1];
        Array.Fill(dp,-1);
        return solve(nums,0,dp);
    }
}