public class Solution {
    private bool solve(int[,] dp,string s,IList<string> w, int idx, int prev  ){
        if(idx >= s.Length){
            if(prev==idx){
                dp[idx,prev]=1;
                return true;
            }
            dp[idx,prev]=0;
            return false;
        }
        if(dp[idx,prev] != -1) return dp[idx,prev]==1?true:false;
        string t = s.Substring(prev,idx-prev+1);
        bool notcheck = solve(dp,s,w,idx+1,prev);
        bool check = solve(dp,s,w,idx+1,w.Contains(t)?idx+1:prev);
        if(check || notcheck) dp[idx,prev]=1;
        else dp[idx,prev] = 0;
        return (check || notcheck);
    }
    public bool WordBreak(string s, IList<string> wordDict) {
        var dp = new int[s.Length+1,s.Length+1];
        for(int i=0; i<=s.Length;i++){
            for(int j=0; j<=s.Length;j++){
                dp[i,j]=-1;
            }
        }
        return solve(dp,s,wordDict,0,0);
    }
}