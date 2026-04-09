public class Solution {
    private int solve(int[,] dp,string t1, string t2, int i, int j){
        if(t1.Length == i || t2.Length == j){
            return 0;
        }
        if(dp[i,j] != -1) return dp[i,j];
        else if(t1[i] == t2[j]){
            return 1 + solve(dp,t1,t2,i+1,j+1);
        }
        int l = solve(dp,t1,t2,i+1,j);
        int r = solve(dp,t1,t2,i,j+1);
        return dp[i,j]= Math.Max(l,r);
    }
    public int LongestCommonSubsequence(string text1, string text2) {
        var dp = new int[text1.Length+1,text2.Length+1];
        for(int i=0; i<text1.Length;i++){
            for(int j=0; j<text2.Length;j++){
                dp[i,j] = -1;
            }
        }
        int ans = solve(dp,text1, text2, 0,0);
        return ans;
    }
}