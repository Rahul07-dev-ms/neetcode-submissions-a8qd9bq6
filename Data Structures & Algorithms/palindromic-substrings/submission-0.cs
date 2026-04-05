public class Solution {
    private bool check(bool?[,] dp, string s, int i, int j){
        if(i >= j) return true;
        if(dp[i,j] != null) return dp[i,j].Value;
        if(s[i] == s[j]){
            dp[i,j] = check(dp,s,i+1,j-1);
        }
        else{
            dp[i,j] = false;
        }
        return dp[i,j].Value;

    }
    public int CountSubstrings(string s) {
        int m = s.Length;
        int ans = 0;
        var dp = new bool?[m+1,m+1];
        for(int i=0; i<m; i++){
            for(int j=i; j<m; j++){
                if(check(dp,s,i,j) == true){
                    ans++;
                }
            }
        }
        return ans;
    }
}