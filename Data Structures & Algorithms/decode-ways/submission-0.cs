public class Solution {
    private int solve(string s, int i,int[] dp){
        if(i >= s.Length) return 1;
        if(s[i]=='0') return 0;
        if(dp[i]!=-1) return dp[i];
        int l = solve(s,i+1,dp);
        int r = 0, no = 0;
        if(i+1 < s.Length){
            string res = s[i].ToString() + s[i+1].ToString();
            no = Convert.ToInt32(res);
        }
        if(no!=0 && no<=26){
            r = solve(s,i+2,dp);
        }
        return dp[i]=l + r;
        
    }
    public int NumDecodings(string s) {
        int[] dp = new int[s.Length+1];
        Array.Fill(dp,-1);
        return solve(s,0,dp);
    }
}