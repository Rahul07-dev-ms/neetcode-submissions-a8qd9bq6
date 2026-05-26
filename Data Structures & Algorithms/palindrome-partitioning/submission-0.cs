public class Solution {
    private bool check(string op){
        if(op.Length==1) return true;
        int start = 0;
        int end = op.Length-1;
        while(end>start){
            if(op[start++]!=op[end--]){
                return false;
            }
        }
        return true;
    }
    private void solve(List<List<string>> ans, string s, int idx, List<string> res){
        if(idx == s.Length){
            ans.Add(new List<string>(res));
            return;
        }
        for(int i=idx; i<s.Length; i++){
            string st = s.Substring(idx,i-idx+1);
            if(check(st)) {
                res.Add(st);
            }
            else continue;
            solve(ans,s,i+1,res);
            res.RemoveAt(res.Count-1);
        }
    }
    public List<List<string>> Partition(string s) {
        var ans = new List<List<string>>();
        var res = new List<string>();
        solve(ans,s,0,res);
        return ans;
    }
}